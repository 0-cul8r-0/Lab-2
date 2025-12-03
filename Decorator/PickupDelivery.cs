using System;

namespace Decorator
{
    public class PickupDelivery : DeliverySystem
    {
        private decimal baseCost = 0;
        private int deliveryDays = 0;

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
            return "Самовывоз";
        }
    }
}

