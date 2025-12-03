using System;

namespace Decorator
{
    public abstract class DeliverySystem
    {
        public abstract decimal CalculateCost();

        public abstract int GetDeliveryDays();

        public abstract string GetDescription();
    }
}

