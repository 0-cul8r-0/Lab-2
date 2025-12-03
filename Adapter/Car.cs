using System;

namespace Adapter
{
    public class Car : ITransport
    {
        private string _model;

        public Car(string model)
        {
            _model = model;
        }

        public void Go(IRoad road)
        {
            Console.WriteLine($"Машина '{_model}' едет по {road.GetRoadType()}");
        }
    }
}

