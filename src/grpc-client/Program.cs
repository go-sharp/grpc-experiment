using System;
using System.IO;
using Grpc.Core;
using static GrpcExample.Services.TodoService;

namespace GrpcExample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var sslCredential = new SslCredentials(File.ReadAllText("../../certs/cert.pem"));
            Console.WriteLine("Starting todo client...");
            var ch = new Channel("localhost:5000", sslCredential);
            var client = new TodoServiceClient(ch);
            var cmd = new CmdClient(client);

            cmd.Run();
        }
    }
}
