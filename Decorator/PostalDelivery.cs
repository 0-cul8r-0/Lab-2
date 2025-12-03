using System;

namespace Decorator
{
    public class PostalDelivery : DeliverySystem
    {
        private decimal baseCost = 300;
        private int deliveryDays = 7;

        public override decimal CalculateCost()
        {
            return baseCost;
        }

        public override int GetDeliveryDays()
        {
            return deliveryDays;
        }

        public override string GetDescription()
        {
            return "Почтовая доставка";
        }
    }
}

