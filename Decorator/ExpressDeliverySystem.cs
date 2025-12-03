using System;

namespace Decorator
{
    public class ExpressDeliverySystem : DeliverySystem
    {
        private DeliverySystem baseDelivery;
        private decimal expressCostMultiplier = 1.5m;
        private int expressDaysReduction = 2;

        public ExpressDeliverySystem(DeliverySystem delivery)
        {
            this.baseDelivery = delivery;
        }

        public string GetDeliveryStatus(string orderId)
        {
            return CourierServiceAPI.GetDeliveryStatus(orderId);
        }

        public override decimal CalculateCost()
        {
            decimal baseCost = baseDelivery.CalculateCost();
            decimal expressCost = CourierServiceAPI.CalculateExpressCost(baseCost, expressCostMultiplier);
            return expressCost;
        }

        public override int GetDeliveryDays()
        {
            int baseDays = baseDelivery.GetDeliveryDays();
            int expressDays = Math.Max(1, baseDays - expressDaysReduction);
            return expressDays;
        }

        public override string GetDescription()
        {
            return baseDelivery.GetDescription() + " (Экспресс)";
        }
    }
}

