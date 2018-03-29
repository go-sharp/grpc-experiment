using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace GrpcExample.Server
{
    public class Log
    {
        private static ILoggerFactory factory;
        static Log()
        {
            factory = new LoggerFactory()
            .AddConsole()
            .AddDebug();
        }

        public static ILogger CreateLogger<T>() => factory.CreateLogger<T>();

        public static void Dispose() => factory.Dispose();
    }
}