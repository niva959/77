//задание 2
//using System;

//namespace deadinside
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Введите ваше имя: ");
//            string name = Console.ReadLine();
//            Console.Write("Введите вашу фамилию: ");
//            string surname = Console.ReadLine();
//            Console.WriteLine("Ваше имя: " + name);
//            Console.WriteLine("Ваша фамилия: " + surname);
//        }
//    }
//}
//задание 3------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//namespace deadinside
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Введите ваше имя: ");
//            string name = Console.ReadLine();
//            Console.Write("Введите ваш возраст: ");
//            int age = int.Parse(Console.ReadLine());
//            Console.WriteLine("Ваше имя: " + name);
//            Console.WriteLine("Ваш возраст: " + age);
//        }
//    }
//}
//задание 4-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//namespace deadinside
//{
//    class Program
//    {
//        static void Main()
//        {
//            // Запрос дня недели
//            Console.WriteLine("Введите день недели:");
//            string dayOfWeek = Console.ReadLine();

//            // Запрос месяца
//            Console.WriteLine("Введите название месяца:");
//            string month = Console.ReadLine();

//            // Запрос даты
//            Console.WriteLine("Введите дату (номер дня в месяце):");
//            string date = Console.ReadLine();

//            // Формирование сообщения о сегодняшней дате
//            string message = $"Сегодня {dayOfWeek}, {date} {month}.";

//            // Вывод сообщения
//            Console.WriteLine(message);
//        }
//    }
//}
//задание 5--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//namespace deadinside
//{
//    class Program
//    {
//        static void Main()
//        {
//            // Запрос названия месяца
//            Console.WriteLine("Введите название месяца:");
//            string month = Console.ReadLine();

//            // Запрос количества дней
//            Console.WriteLine("Введите количество дней в этом месяце:");
//            int days = int.Parse(Console.ReadLine());

//            // Формирование сообщения
//            string message = $"Месяц {month} содержит {days} дней.";

//            // Вывод сообщения
//            Console.WriteLine(message);
//        }
//    }
//}
//задание 6-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//namespace deadinside
//{
//    class Program
//    {
//        static void Main()
//        {
//            // Запрос года рождения
//            Console.WriteLine("Введите год вашего рождения:");
//            int birthYear = int.Parse(Console.ReadLine());

//            // Получение текущего года
//            int currentYear = DateTime.Now.Year;

//            // Вычисление возраста
//            int age = currentYear - birthYear;

//            // Формирование сообщения
//            string message = $"Ваш возраст: {age} лет.";

//            // Вывод сообщения
//            Console.WriteLine(message);
//        }
//    }
//}
//задание 7-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//namespace deadinside
//{
//    class Program
//    {
//        static void Main()
//        {
//            // Запрос имени пользователя
//            Console.Write("Введите ваше имя: ");
//                        string name = Console.ReadLine();
//            // Запрос года рождения
//            Console.WriteLine("Введите год вашего рождения:");
//                        int birthYear = int.Parse(Console.ReadLine());

//            // Получение текущего года
//            int currentYear = DateTime.Now.Year;

//            // Вычисление возраста
//            int age = currentYear - birthYear;

//            // Формирование сообщения
//            string message = $"Здравствуйте, {name}! Ваш возраст: {age} лет.";

//            // Вывод сообщения
//            Console.WriteLine(message, "Возраст");
//        }
//    }
//}
//задание8------------------------------------------------------------------------------------------------------------------------------------------------------------------------ -
//using System;

//namespace deadinside
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите ваш возраст:");
//            int age = int.Parse(Console.ReadLine());

//            int currentYear = DateTime.Now.Year;
//            int birthYear = currentYear - age;

//            Console.WriteLine($"Год вашего рождения: {birthYear}");

//            Console.ReadLine();
//        }
//    }
//}
//задание9------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//namespace deadinside
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите первое число:");
//            int num1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Введите второе число:");
//            int num2 = int.Parse(Console.ReadLine());

//            int sum = num1 + num2;

//            Console.WriteLine($"Сумма чисел: {sum}");

//            Console.ReadLine();
//        }
//    }
//}
//задание10------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;

namespace deadinside
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());

            int previousNumber = number - 1;
            int nextNumber = number + 1;

            Console.WriteLine($"Последовательность чисел: {previousNumber}, {number}, {nextNumber}");

            Console.ReadLine();
        }
    }
}