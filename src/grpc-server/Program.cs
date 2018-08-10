namespace GrpcExample.Server
{
    using System;
    using System.IO;
    using Grpc.Core;
    using Grpc.Core.Interceptors;
    using GrpcExample.Services;
    using Microsoft.Extensions.Logging;

    class Program
    {
        private static ILogger Logger = Log.CreateLogger<Program>();
        static void Main(string[] args)
        {
            var sslCredential = new SslServerCredentials(new KeyCertificatePair[] { new KeyCertificatePair(File.ReadAllText("../../certs/cert.pem"), File.ReadAllText("../../certs/key.pem")) });
            var serviceDefinition = TodoService.BindService(new GrpcServer());
            serviceDefinition = serviceDefinition.Intercept(new CustomAuthenticationInterceptor());

            var server = new Server()
            {
                Services = { serviceDefinition },
                Ports = { new ServerPort("localhost", 5000, sslCredential) }
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
