using System;

namespace Decorator
{
    public static class CourierServiceAPI
    {
        public static string GetDeliveryStatus(string orderId)
        {
            if (string.IsNullOrEmpty(orderId))
            {
                return "Ошибка: номер заказа не указан";
            }

            Random random = new Random();
            string[] statuses = { "В обработке", "Отправлен", "В пути", "Доставлен" };
            return statuses[random.Next(statuses.Length)];
        }

        public static decimal CalculateExpressCost(decimal baseCost, decimal multiplier)
        {
            return baseCost * multiplier;
        }
    }
}

