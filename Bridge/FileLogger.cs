using System;
using System.IO;

namespace Bridge
{
    public class FileLogger : ILogger
    {
        private string _filePath;

        public FileLogger(string filePath = "log.txt")
        {
            _filePath = filePath;
        }

        public void Log(string message, string level)
        {
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";
            File.AppendAllText(_filePath, logEntry + Environment.NewLine);
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        public void LogWarning(string message)
        {
            Log(message, "WARNING");
        }
    }
}

