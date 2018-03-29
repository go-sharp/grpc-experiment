namespace GrpcExample.Server
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using GrpcExample.Services;
    using Microsoft.Extensions.Logging;

    public class GrpcServer : TodoService.TodoServiceBase
    {
        private static ILogger Logger = Log.CreateLogger<GrpcServer>();   
        private readonly object mylock = new Object();
        private readonly Dictionary<int, Todo> todos = new Dictionary<int, Todo>();
        private int id = 1;

        public override Task<TodoResponse> Create(Todo request, Grpc.Core.ServerCallContext context) {
            var response = new TodoResponse() { Status = Status.Ok };
            if(request.Id != 0 || string.IsNullOrEmpty(request.Text) ) {
                Logger.LogWarning("invalid todo received {@Todo}", request);
                response.Status = Status.Failed;
                response.Error = new Error() { Text = request.Id  == 0 ? "id must not be set" : "a todo needs a title" };
                return Task.FromResult(response);
            }

            lock (this.mylock)
            {
                request.Id = this.id++;
                this.todos.Add(request.Id, request);
            }

            Logger.LogInformation("todo successfully created {@Todo}", request);
            response.Todo = request;
            return Task.FromResult(response);
        }

        public override Task<TodoResponse> Update(Todo request, Grpc.Core.ServerCallContext context) {
            var response = new TodoResponse() { Status = Status.Ok };
            if(request.Id == 0 || string.IsNullOrEmpty(request.Text) ) {
                Logger.LogWarning("invalid todo received {@Todo}", request);
                response.Status = Status.Failed;
                response.Error = new Error() { Text = request.Id  == 0 ? "id must be set" : "a todo needs a title" };
                return Task.FromResult(response);
            }

            lock (this.mylock)
            {
                if (!this.todos.ContainsKey(request.Id)) {
                    Logger.LogWarning("id {ID} not found", request.Id);
                    response.Status = Status.Failed;
                    response.Error = new Error() { Text = $"id {request.Id} not found"};
                    return Task.FromResult(response);
                } 
                response.Todo = this.todos[request.Id] = request;
            }
            Logger.LogInformation("todo successfully updated {@Todo}", request);
            return Task.FromResult(response);
        }

        public override Task<DeleteResponse> Delete(DeleteRequest request, Grpc.Core.ServerCallContext context)  {
            var response = new DeleteResponse() { Status = Status.Ok};
            if(request.Id == 0) {
                response.Status = Status.Failed;
                Logger.LogWarning("can not delete a todo with id {ID}", request.Id);
                return Task.FromResult(response);
            }
            
            lock (this.mylock)
            {
                this.todos.Remove(request.Id);
            }

            return Task.FromResult(response);
        }

        public override Task<Todos> List(Services.Void request, Grpc.Core.ServerCallContext context) {
            var response = new Todos();
            lock (this.mylock)
            {
                response.Todos_.Add(this.todos.Select(p => p.Value).ToArray());
            }

            return Task.FromResult(response);
        }
    }

}