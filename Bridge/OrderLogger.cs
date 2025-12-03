namespace Bridge
{
    public class OrderLogger : LoggingMechanism
    {
        public OrderLogger(ILogger logger) : base(logger)
        {
        }

        public override void LogAction(string action, string details)
        {
            _logger.LogInfo($"Заказ: {action} - {details}");
        }

        public override void LogError(string error)
        {
            _logger.LogError($"Ошибка при работе с заказом: {error}");
        }

        public override void LogInfo(string info)
        {
            _logger.LogInfo($"Информация о заказе: {info}");
        }

        public void LogOrderCreated(int orderId, string customerName)
        {
            LogAction("Создан заказ", $"ID: {orderId}, Клиент: {customerName}");
        }

        public void LogOrderStatusChanged(int orderId, string oldStatus, string newStatus)
        {
            LogInfo($"Заказ #{orderId}: статус изменен с '{oldStatus}' на '{newStatus}'");
        }
    }
}

