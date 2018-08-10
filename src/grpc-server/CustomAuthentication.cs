

namespace GrpcExample.Server
{
    using System;
    using System.Threading.Tasks;
    using Grpc.Core;
    using Grpc.Core.Interceptors;
    using Microsoft.Extensions.Logging;

    public class CustomAuthenticationInterceptor : Interceptor
    {
        private readonly ILogger logger = GrpcExample.Server.Log.CreateLogger<CustomAuthenticationInterceptor>();
        public CustomAuthenticationInterceptor()
        {
        }

        public override Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
        {
            this.Log(context);
            return continuation(request, context);
        }

        public override Task<TResponse> ClientStreamingServerHandler<TRequest, TResponse>(IAsyncStreamReader<TRequest> requestStream, ServerCallContext context, ClientStreamingServerMethod<TRequest, TResponse> continuation)
        {
            this.Log(context);
            return continuation(requestStream, context);
        }

        public override Task ServerStreamingServerHandler<TRequest, TResponse>(TRequest request, IServerStreamWriter<TResponse> responseStream, ServerCallContext context, ServerStreamingServerMethod<TRequest, TResponse> continuation)
        {
            this.Log(context);
            return continuation(request, responseStream, context);
        }

        public override Task DuplexStreamingServerHandler<TRequest, TResponse>(IAsyncStreamReader<TRequest> requestStream, IServerStreamWriter<TResponse> responseStream, ServerCallContext context, DuplexStreamingServerMethod<TRequest, TResponse> continuation)
        {
            this.Log(context);
            return continuation(requestStream, responseStream, context);
        }

        private void Log(ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unauthenticated, "API Key not valid!"));
            this.logger.LogInformation("Call intercepted...");
            if (context.RequestHeaders != null)
            {
                foreach (var entry in context.RequestHeaders)
                {
                    this.logger.LogInformation("Key: {Key}, Value: {Value}", entry.Key, entry.Value);
                }
            }
        }
    }

}