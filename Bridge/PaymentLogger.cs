namespace Bridge
{
    public class PaymentLogger : LoggingMechanism
    {
        public PaymentLogger(ILogger logger) : base(logger)
        {
        }

        public override void LogAction(string action, string details)
        {
            _logger.LogInfo($"Платеж: {action} - {details}");
        }

        public override void LogError(string error)
        {
            _logger.LogError($"Ошибка при обработке платежа: {error}");
        }

        public override void LogInfo(string info)
        {
            _logger.LogInfo($"Информация о платеже: {info}");
        }

        public void LogPaymentProcessed(int paymentId, decimal amount)
        {
            LogAction("Обработан платеж", $"ID: {paymentId}, Сумма: {amount:C}");
        }

        public void LogPaymentFailed(int paymentId, string reason)
        {
            LogError($"Платеж #{paymentId} не прошел: {reason}");
        }
    }
}

