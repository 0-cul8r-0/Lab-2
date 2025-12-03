using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Демонстрация паттерна Adapter ===\n");

            IRoad asphaltRoad = new Road("асфальтированной дороге");
            IRoad dirtRoad = new Road("грунтовой дороге");

            ITransport car = new Car("BMW");
            Console.WriteLine("1. Машина (обычный транспорт):");
            car.Go(asphaltRoad);
            car.Go(dirtRoad);
            Console.WriteLine();

            Donkey donkey = new Donkey("Иа");
            Console.WriteLine("2. Осёл (не является транспортом):");
            donkey.Eat();
            Console.WriteLine();

            ITransport donkeyWithSaddle = new Saddle(donkey);
            Console.WriteLine("3. Осёл с седлом (адаптирован как транспорт):");
            donkeyWithSaddle.Go(asphaltRoad);
            donkeyWithSaddle.Go(dirtRoad);
            Console.WriteLine();

            Console.WriteLine("4. Полиморфизм - все транспорты используют один интерфейс:");
            ITransport[] transports = { car, donkeyWithSaddle };
            foreach (var transport in transports)
            {
                transport.Go(asphaltRoad);
            }

            Console.WriteLine("\n=== Конец демонстрации ===");
            Console.ReadKey();
        }
    }
}
