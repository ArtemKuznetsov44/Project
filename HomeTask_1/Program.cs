using System;

namespace HomeTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуй ! Пожалуйста, введи свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");
            Console.Read(); 
        }
    }
}
