namespace GrpcExample.Server
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Grpc.Core;
    using GrpcExample.Services;
    using Microsoft.Extensions.Logging;

    public class GrpcServer : TodoService.TodoServiceBase
    {
        private static ILogger Logger = Log.CreateLogger<GrpcServer>();
        private readonly object mylock = new Object();
        private readonly Dictionary<int, Todo> todos = new Dictionary<int, Todo>() {
            { 1, new Todo { Id = 1, Done = true, Text = "Create Server" } },
            { 2, new Todo { Id = 2, Done = false, Text = "Create Client" } },
            { 3, new Todo { Id = 3, Done = true, Text = "Create Service" } },
        };
        private int id = 4;

        public override Task<Todo> Create(Todo request, Grpc.Core.ServerCallContext context)
        {
            if (request.Id != 0 || string.IsNullOrEmpty(request.Text))
            {
                Logger.LogWarning("invalid todo received {@Todo}", request);
                throw new RpcException(new Status(StatusCode.InvalidArgument
                , request.Id != 0 ? "id must not be set" : "a todo needs a title"));
            }

            lock (this.mylock)
            {
                request.Id = this.id++;
                this.todos.Add(request.Id, request);
            }

            Logger.LogInformation("todo successfully created {@Todo}", request);
            return Task.FromResult(request);
        }

        public override Task<Todo> Update(Todo request, Grpc.Core.ServerCallContext context)
        {
            if (request.Id == 0 || string.IsNullOrEmpty(request.Text))
            {
                Logger.LogWarning("invalid todo received {@Todo}", request);
                throw new RpcException(new Status(StatusCode.InvalidArgument
                , request.Id == 0 ? "id must be set" : "a todo needs a title"));
            }

            lock (this.mylock)
            {
                if (!this.todos.ContainsKey(request.Id))
                {
                    Logger.LogWarning("id {ID} not found", request.Id);
                    throw new RpcException(new Status(StatusCode.NotFound, $"id {request.Id} not found"));
                }
                this.todos[request.Id] = request;
            }
            Logger.LogInformation("todo successfully updated {@Todo}", request);
            return Task.FromResult(request);
        }

        public override Task<Empty> Delete(DeleteRequest request, Grpc.Core.ServerCallContext context)
        {
            if (request.Id == 0)
            {
                Logger.LogWarning("can not delete a todo with id {ID}", request.Id);
                throw new RpcException(new Status(StatusCode.InvalidArgument
                , $"can not delete a todo with id {request.Id}"));
            }

            lock (this.mylock)
            {
                this.todos.Remove(request.Id);
            }

            return Task.FromResult(new Empty());
        }

        public override Task<Todo> Get(TodoRequest request, Grpc.Core.ServerCallContext context)
        {
            if (request.Id == 0)
            {
                Logger.LogWarning("id must be greater than 0");
                throw new RpcException(new Status(StatusCode.InvalidArgument, "id must be greater than 0"));
            }

            Todo todo;
            lock (this.mylock)
            {
                if (!this.todos.ContainsKey(request.Id))
                {
                    Logger.LogWarning("id {ID} not found", request.Id);
                    throw new RpcException(new Status(StatusCode.NotFound, $"id {request.Id} not found"));
                }
                todo = this.todos[request.Id];
            }

            return Task.FromResult(todo);
        }

        public override Task<Todos> List(Empty request, Grpc.Core.ServerCallContext context)
        {
            Logger.LogInformation("calling rpc service operation 'List'");
            var response = new Todos();
            lock (this.mylock)
            {
                response.Todos_.Add(this.todos.Select(p => p.Value).ToArray());
            }

            return Task.FromResult(response);
        }
    }

}