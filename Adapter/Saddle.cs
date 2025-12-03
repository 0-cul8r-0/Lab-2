using System;

namespace Adapter
{
    public class Saddle : ITransport
    {
        private Donkey _donkey;

        public Saddle(Donkey donkey)
        {
            _donkey = donkey;
        }

        public void Go(IRoad road)
        {
            Console.WriteLine($"Осёл '{_donkey.GetName()}' с седлом идёт по {road.GetRoadType()}");
        }
    }
}

