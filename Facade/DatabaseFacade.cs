using System;
using System.Collections.Generic;

namespace Facade
{
    public class DatabaseFacade
    {
        private Database1Access db1;
        private Database2Access db2;

        public DatabaseFacade(string connectionString1, string connectionString2)
        {
            db1 = new Database1Access(connectionString1);
            db2 = new Database2Access(connectionString2);
        }

        public void Connect()
        {
            Console.WriteLine("\n=== Подключение через Facade ===");
            db1.Connect();
            db2.Connect();
            Console.WriteLine("=== Подключение завершено ===\n");
        }

        public void SaveToDatabase1(string data)
        {
            Console.WriteLine("\n=== Сохранение в БД 1 через Facade ===");
            db1.Insert(data);
            Console.WriteLine("=== Сохранение завершено ===\n");
        }

        public void SaveToDatabase2(string key, string value)
        {
            Console.WriteLine("\n=== Сохранение в БД 2 через Facade ===");
            db2.Insert(key, value);
            Console.WriteLine("=== Сохранение завершено ===\n");
        }

        public List<string> GetFromDatabase1(string query)
        {
            Console.WriteLine("\n=== Получение данных из БД 1 через Facade ===");
            var result = db1.Select(query);
            Console.WriteLine("=== Получение завершено ===\n");
            return result;
        }

        public Dictionary<string, string> GetFromDatabase2(string query)
        {
            Console.WriteLine("\n=== Получение данных из БД 2 через Facade ===");
            var result = db2.Select(query);
            Console.WriteLine("=== Получение завершено ===\n");
            return result;
        }

        public void UpdateDatabase1(string data)
        {
            Console.WriteLine("\n=== Обновление данных в БД 1 через Facade ===");
            db1.Update(data);
            Console.WriteLine("=== Обновление завершено ===\n");
        }

        public void UpdateDatabase2(string key, string value)
        {
            Console.WriteLine("\n=== Обновление данных в БД 2 через Facade ===");
            db2.Update(key, value);
            Console.WriteLine("=== Обновление завершено ===\n");
        }

        public void DeleteFromDatabase1(string data)
        {
            Console.WriteLine("\n=== Удаление данных из БД 1 через Facade ===");
            db1.Delete(data);
            Console.WriteLine("=== Удаление завершено ===\n");
        }

        public void DeleteFromDatabase2(string key)
        {
            Console.WriteLine("\n=== Удаление данных из БД 2 через Facade ===");
            db2.Delete(key);
            Console.WriteLine("=== Удаление завершено ===\n");
        }

        public void Disconnect()
        {
            Console.WriteLine("\n=== Отключение через Facade ===");
            db1.Disconnect();
            db2.Disconnect();
            Console.WriteLine("=== Отключение завершено ===\n");
        }
    }
}

