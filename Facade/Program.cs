using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("=== Демонстрация паттерна Facade ===\n");

            DatabaseFacade facade = new DatabaseFacade(
                "Server=localhost;Database=Database1;User=admin;",
                "Host=localhost;Database=Database2;User=admin;"
            );

            facade.Connect();

            facade.SaveToDatabase1("Запись 1");
            facade.SaveToDatabase1("Запись 2");
            var data1 = facade.GetFromDatabase1("SELECT * FROM Table1");
            Console.WriteLine($"Получено записей из БД 1: {data1.Count}");

            facade.SaveToDatabase2("key1", "Значение 1");
            facade.SaveToDatabase2("key2", "Значение 2");
            var data2 = facade.GetFromDatabase2("SELECT * FROM Table2");
            Console.WriteLine($"Получено записей из БД 2: {data2.Count}");

            facade.UpdateDatabase1("Запись 1 (обновлено)");
            facade.UpdateDatabase2("key1", "Новое значение 1");

            facade.DeleteFromDatabase1("Запись 2");
            facade.DeleteFromDatabase2("key2");

            facade.Disconnect();

            Console.WriteLine("\n=== Демонстрация завершена ===");
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
