using System;
using Grpc.Core;
using static GrpcExample.Services.TodoService;

namespace GrpcExample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting todo client...");
            var ch = new Channel("127.0.0.1:5000", ChannelCredentials.Insecure);
            var client = new TodoServiceClient(ch);
            var cmd = new CmdClient(client);

            cmd.Run();
        }
    }
}
