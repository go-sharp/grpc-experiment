using System;
using Microsoft.Extensions.Logging;

namespace Grpc.Server
{
    class Program
    {
        private static ILogger Logger = Log.CreateLogger<Program>();
        static void Main(string[] args)
        {
            Logger.LogInformation("Starting grpc console server...");


            Log.Dispose();
        }
    }
}
