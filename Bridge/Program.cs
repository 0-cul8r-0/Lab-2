using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Демонстрация паттерна Bridge для логирования в интернет-магазине ===\n");

            ILogger consoleLogger = new ConsoleLogger();
            ILogger fileLogger = new FileLogger("shop_log.txt");

            Console.WriteLine("--- Логирование в консоль ---\n");

            OrderLogger orderLogger = new OrderLogger(consoleLogger);
            orderLogger.LogOrderCreated(1001, "Иван Иванов");
            orderLogger.LogOrderStatusChanged(1001, "Новый", "В обработке");
            orderLogger.LogInfo("Заказ успешно обработан");

            PaymentLogger paymentLogger = new PaymentLogger(consoleLogger);
            paymentLogger.LogPaymentProcessed(2001, 1500.50m);
            paymentLogger.LogPaymentFailed(2002, "Недостаточно средств");

            UserLogger userLogger = new UserLogger(consoleLogger);
            userLogger.LogUserRegistration("john_doe", "john@example.com");
            userLogger.LogUserLogin("john_doe");

            Console.WriteLine("\n--- Логирование в файл ---\n");

            OrderLogger fileOrderLogger = new OrderLogger(fileLogger);
            fileOrderLogger.LogOrderCreated(1002, "Петр Петров");
            fileOrderLogger.LogOrderStatusChanged(1002, "В обработке", "Отправлен");

            PaymentLogger filePaymentLogger = new PaymentLogger(fileLogger);
            filePaymentLogger.LogPaymentProcessed(2003, 2500.00m);

            UserLogger fileUserLogger = new UserLogger(fileLogger);
            fileUserLogger.LogUserLogin("petr_petrov");

            Console.WriteLine("Логи записаны в файл shop_log.txt\n");

            Console.WriteLine("--- Преимущества паттерна Bridge ---");
            Console.WriteLine("1. Абстракция (LoggingMechanism) отделена от реализации (ILogger)");
            Console.WriteLine("2. Можно легко добавлять новые типы логирования (OrderLogger, PaymentLogger)");
            Console.WriteLine("3. Можно легко добавлять новые реализации (ConsoleLogger, FileLogger, DatabaseLogger)");
            Console.WriteLine("4. Изменения в одной части не влияют на другую");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
