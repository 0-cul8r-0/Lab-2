using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Демонстрация паттерна Composite для склада ===\n");

            Product laptop = new Product("Ноутбук", 50000);
            Product mouse = new Product("Мышь", 500);
            Product keyboard = new Product("Клавиатура", 1500);
            Product monitor = new Product("Монитор", 15000);
            Product headphones = new Product("Наушники", 3000);
            Product phone = new Product("Телефон", 25000);
            Product charger = new Product("Зарядное устройство", 800);

            Console.WriteLine("Созданы продукты:");
            Console.WriteLine($"  {laptop.GetName()}: {laptop.GetPrice()} руб.");
            Console.WriteLine($"  {mouse.GetName()}: {mouse.GetPrice()} руб.");
            Console.WriteLine($"  {keyboard.GetName()}: {keyboard.GetPrice()} руб.");
            Console.WriteLine($"  {monitor.GetName()}: {monitor.GetPrice()} руб.");
            Console.WriteLine($"  {headphones.GetName()}: {headphones.GetPrice()} руб.");
            Console.WriteLine($"  {phone.GetName()}: {phone.GetPrice()} руб.");
            Console.WriteLine($"  {charger.GetName()}: {charger.GetPrice()} руб.\n");

            Box smallBox1 = new Box("Маленькая коробка 1", 50);
            smallBox1.Add(mouse);
            smallBox1.Add(keyboard);

            Box smallBox2 = new Box("Маленькая коробка 2", 50);
            smallBox2.Add(phone);
            smallBox2.Add(charger);

            Box mediumBox = new Box("Средняя коробка", 100);
            mediumBox.Add(laptop);
            mediumBox.Add(smallBox1);

            Box largeBox = new Box("Большая коробка", 200);
            largeBox.Add(monitor);
            largeBox.Add(headphones);
            largeBox.Add(mediumBox);

            Console.WriteLine("Созданы коробки:");
            Console.WriteLine($"  {smallBox1.GetName()}: {smallBox1.GetPrice()} руб. (содержит: мышь, клавиатура)");
            Console.WriteLine($"  {smallBox2.GetName()}: {smallBox2.GetPrice()} руб. (содержит: телефон, зарядное устройство)");
            Console.WriteLine($"  {mediumBox.GetName()}: {mediumBox.GetPrice()} руб. (содержит: ноутбук + маленькая коробка 1)");
            Console.WriteLine($"  {largeBox.GetName()}: {largeBox.GetPrice()} руб. (содержит: монитор, наушники + средняя коробка)\n");

            Order order1 = new Order("ORD-001");
            order1.AddItem(largeBox);
            order1.AddItem(smallBox2);
            order1.AddItem(new Product("Кабель USB", 300));

            Console.WriteLine($"Заказ {order1.GetOrderNumber()}:");
            Console.WriteLine($"  - {largeBox.GetName()}");
            Console.WriteLine($"  - {smallBox2.GetName()}");
            Console.WriteLine($"  - Кабель USB (300 руб.)");
            Console.WriteLine($"\nОбщая стоимость заказа: {order1.GetTotalPrice()} руб.\n");

            Order order2 = new Order("ORD-002");
            order2.AddItem(new Product("Планшет", 20000));
            order2.AddItem(new Product("Чехол для планшета", 1500));
            order2.AddItem(mediumBox);

            Console.WriteLine($"Заказ {order2.GetOrderNumber()}:");
            Console.WriteLine($"  - Планшет (20000 руб.)");
            Console.WriteLine($"  - Чехол для планшета (1500 руб.)");
            Console.WriteLine($"  - {mediumBox.GetName()}");
            Console.WriteLine($"\nОбщая стоимость заказа: {order2.GetTotalPrice()} руб.\n");

            Console.WriteLine("=== Детальная информация о большой коробке ===");
            Console.WriteLine($"Название: {largeBox.GetName()}");
            Console.WriteLine($"Цена коробки: 200 руб.");
            Console.WriteLine($"Содержимое:");
            Console.WriteLine($"  - Монитор: 15000 руб.");
            Console.WriteLine($"  - Наушники: 3000 руб.");
            Console.WriteLine($"  - Средняя коробка ({mediumBox.GetPrice()} руб.):");
            Console.WriteLine($"      - Цена коробки: 100 руб.");
            Console.WriteLine($"      - Ноутбук: 50000 руб.");
            Console.WriteLine($"      - Маленькая коробка 1 ({smallBox1.GetPrice()} руб.):");
            Console.WriteLine($"          - Цена коробки: 50 руб.");
            Console.WriteLine($"          - Мышь: 500 руб.");
            Console.WriteLine($"          - Клавиатура: 1500 руб.");
            Console.WriteLine($"\nИтого большая коробка: {largeBox.GetPrice()} руб.");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
