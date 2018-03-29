namespace GrpcExample.Server
{
    using System;
    using Grpc.Core;
    using GrpcExample.Services;
    using Microsoft.Extensions.Logging;

    class Program
    {
        private static ILogger Logger = Log.CreateLogger<Program>();
        static void Main(string[] args)
        {
            var server = new Server()
            {
                Services = { TodoService.BindService(new GrpcServer()) },
                Ports = { new ServerPort("localhost", 5000, ServerCredentials.Insecure) }
            };

            Logger.LogInformation("Starting grpc console server...");
            server.Start();

            Console.WriteLine("Press Ctrl+C to quit server...");
            server.ShutdownTask.Wait();

            Logger.LogInformation("Shutdown server...");
            Log.Dispose();
        }
    }
}
