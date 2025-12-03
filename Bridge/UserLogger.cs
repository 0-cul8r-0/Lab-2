namespace Bridge
{
    public class UserLogger : LoggingMechanism
    {
        public UserLogger(ILogger logger) : base(logger)
        {
        }

        public override void LogAction(string action, string details)
        {
            _logger.LogInfo($"Пользователь: {action} - {details}");
        }

        public override void LogError(string error)
        {
            _logger.LogError($"Ошибка при работе с пользователем: {error}");
        }

        public override void LogInfo(string info)
        {
            _logger.LogInfo($"Информация о пользователе: {info}");
        }

        public void LogUserLogin(string username)
        {
            LogAction("Вход в систему", $"Пользователь: {username}");
        }

        public void LogUserRegistration(string username, string email)
        {
            LogAction("Регистрация", $"Пользователь: {username}, Email: {email}");
        }
    }
}

