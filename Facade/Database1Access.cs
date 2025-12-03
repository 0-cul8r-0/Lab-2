using System;
using System.Collections.Generic;

namespace Facade
{
    public class Database1Access
    {
        private string connectionString;
        private List<string> data;

        public Database1Access(string connectionString)
        {
            this.connectionString = connectionString;
            this.data = new List<string>();
            Console.WriteLine($"Подключение к БД 1 установлено: {connectionString}");
        }

        public void Connect()
        {
            Console.WriteLine("Подключение к БД 1...");
        }

        public void Insert(string record)
        {
            Console.WriteLine($"Вставка записи в БД 1: {record}");
            data.Add(record);
        }

        public List<string> Select(string query)
        {
            Console.WriteLine($"Выполнение запроса в БД 1: {query}");
            return new List<string>(data);
        }

        public void Update(string record)
        {
            Console.WriteLine($"Обновление записи в БД 1: {record}");
            if (data.Contains(record))
            {
            }
        }

        public void Delete(string record)
        {
            Console.WriteLine($"Удаление записи из БД 1: {record}");
            data.Remove(record);
        }

        public void Disconnect()
        {
            Console.WriteLine("Отключение от БД 1...");
        }
    }
}

