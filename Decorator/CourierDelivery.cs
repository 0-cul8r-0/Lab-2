using System;

namespace Decorator
{
    public class CourierDelivery : DeliverySystem
    {
        private decimal baseCost = 500;
        private int deliveryDays = 3;

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
            return "Курьерская доставка";
        }
    }
}

