using System;

namespace Bridge
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message, string level)
        {
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}");
        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Log(message, "ERROR");
            Console.ResetColor();
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Log(message, "INFO");
            Console.ResetColor();
        }

        public void LogWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Log(message, "WARNING");
            Console.ResetColor();
        }
    }
}

