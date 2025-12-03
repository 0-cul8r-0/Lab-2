using System;
using System.Collections.Generic;

namespace Facade
{
    public class Database2Access
    {
        private string connectionString;
        private Dictionary<string, string> data;

        public Database2Access(string connectionString)
        {
            this.connectionString = connectionString;
            this.data = new Dictionary<string, string>();
            Console.WriteLine($"Подключение к БД 2 установлено: {connectionString}");
        }

        public void Connect()
        {
            Console.WriteLine("Подключение к БД 2...");
        }

        public void Insert(string key, string value)
        {
            Console.WriteLine($"Вставка записи в БД 2: {key} = {value}");
            data[key] = value;
        }

        public Dictionary<string, string> Select(string query)
        {
            Console.WriteLine($"Выполнение запроса в БД 2: {query}");
            return new Dictionary<string, string>(data);
        }

        public void Update(string key, string value)
        {
            Console.WriteLine($"Обновление записи в БД 2: {key} = {value}");
            if (data.ContainsKey(key))
            {
                data[key] = value;
            }
        }

        public void Delete(string key)
        {
            Console.WriteLine($"Удаление записи из БД 2: {key}");
            data.Remove(key);
        }

        public void Disconnect()
        {
            Console.WriteLine("Отключение от БД 2...");
        }
    }
}

