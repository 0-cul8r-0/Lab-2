using System;

namespace Decorator
{
    public class ExpressDeliveryDecorator : DeliverySystem
    {
        private DeliverySystem deliverySystem;
        private ExpressDeliverySystem expressSystem;

        public ExpressDeliveryDecorator(DeliverySystem delivery)
        {
            this.deliverySystem = delivery;
            this.expressSystem = new ExpressDeliverySystem(delivery);
        }

        public string TrackDeliveryStatus(string orderId)
        {
            return expressSystem.GetDeliveryStatus(orderId);
        }

        public decimal CalculateExpressCost()
        {
            return expressSystem.CalculateCost();
        }

        public override decimal CalculateCost()
        {
            return expressSystem.CalculateCost();
        }

        public override int GetDeliveryDays()
        {
            return expressSystem.GetDeliveryDays();
        }

        public override string GetDescription()
        {
            return expressSystem.GetDescription();
        }
    }
}

