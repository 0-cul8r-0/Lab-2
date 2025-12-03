namespace Bridge
{
    public abstract class LoggingMechanism
    {
        protected ILogger _logger;

        public LoggingMechanism(ILogger logger)
        {
            _logger = logger;
        }

        public abstract void LogAction(string action, string details);
        public abstract void LogError(string error);
        public abstract void LogInfo(string info);
    }
}

