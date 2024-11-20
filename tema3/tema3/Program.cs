using System;
using MyProductLibrary;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса из библиотеки
            var manager = new ProductManager();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить товар");
                Console.WriteLine("2. Выход");
                Console.Write("Введите номер действия: ");
                string choice = Console.ReadLine();

                Console.Clear(); // Очищаем консоль перед выполнением действия

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите название товара: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите дату поступления (дд.мм.гггг): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                        {
                            manager.AddProduct(name, date);
                            Console.Clear(); // Очищаем консоль после ввода
                            Console.WriteLine($"Товар '{name}' с датой {date:dd.MM.yyyy} успешно занесен в базу данных склада.");
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат даты. Нажмите любую клавишу, чтобы продолжить.");
                        }
                        break;

                    case "2":
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Нажмите любую клавишу, чтобы попробовать снова.");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
                Console.ReadKey(); // Ждем нажатия клавиши перед возвратом в меню
            }
        }
    }
}
