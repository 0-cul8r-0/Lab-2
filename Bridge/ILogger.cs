using System;

namespace Bridge
{
    public interface ILogger
    {
        void Log(string message, string level);
        void LogError(string message);
        void LogInfo(string message);
        void LogWarning(string message);
    }
}

