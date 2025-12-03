using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Система доставки интернет-магазина ===\n");

            DeliverySystem courierDelivery = new CourierDelivery();
            DeliverySystem postalDelivery = new PostalDelivery();
            DeliverySystem pickupDelivery = new PickupDelivery();

            Console.WriteLine("Базовые способы доставки:");
            PrintDeliveryInfo(courierDelivery);
            PrintDeliveryInfo(postalDelivery);
            PrintDeliveryInfo(pickupDelivery);

            Console.WriteLine("\n=== Добавление экспресс-доставки через декоратор ===\n");

            ExpressDeliveryDecorator expressCourier = new ExpressDeliveryDecorator(courierDelivery);
            ExpressDeliveryDecorator expressPostal = new ExpressDeliveryDecorator(postalDelivery);

            Console.WriteLine("Экспресс-доставка:");
            PrintDeliveryInfo(expressCourier);
            Console.WriteLine($"Статус доставки: {expressCourier.TrackDeliveryStatus("ORD-12345")}");
            Console.WriteLine($"Стоимость экспресс-доставки: {expressCourier.CalculateExpressCost()} руб.");

            Console.WriteLine();
            PrintDeliveryInfo(expressPostal);
            Console.WriteLine($"Статус доставки: {expressPostal.TrackDeliveryStatus("ORD-67890")}");
            Console.WriteLine($"Стоимость экспресс-доставки: {expressPostal.CalculateExpressCost()} руб.");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static void PrintDeliveryInfo(DeliverySystem delivery)
        {
            Console.WriteLine($"Способ доставки: {delivery.GetDescription()}");
            Console.WriteLine($"Стоимость: {delivery.CalculateCost()} руб.");
            Console.WriteLine($"Время доставки: {delivery.GetDeliveryDays()} дн.");
            Console.WriteLine();
        }
    }
}
