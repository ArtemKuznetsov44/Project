using System;

/*
 * Запросить у пользователя порядковый номер текущего месяца и вывести его название.
 */
namespace HomeTask_2___2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер текущего месяца: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(); 
            switch (count)
            {
                case 1:
                    Console.WriteLine("Сейчас ведь ЯНВАРЬ, не так ли?"); 
                    break;
                case 2:
                    Console.WriteLine("Сейчас ведь ФЕВРАЛЬ, не так ли?");
                    break;
                case 3:
                    Console.WriteLine("Сейчас ведь МАРТ, не так ли?");
                    break;
                case 4:
                    Console.WriteLine("Сейчас ведь АПРЕЛЬ, не так ли?");
                    break;
                case 5:
                    Console.WriteLine("Сейчас ведь МАЙ, не так ли?");
                    break;
                case 6:
                    Console.WriteLine("Сейчас ведь ИЮНЬ, не так ли?");
                    break;
                case 7:
                    Console.WriteLine("Сейчас ведь ИЮЛЬ, не так ли?");
                    break;
                case 8:
                    Console.WriteLine("Сейчас ведь АВГУСТ, не так ли?");
                    break;
                case 9:
                    Console.WriteLine("Сейчас ведь СЕНТЯБРЬ, не так ли?");
                    break;
                case 10:
                    Console.WriteLine("Сейчас ведь ОКТЯБРЬ, не так ли?");
                    break;
                case 11:
                    Console.WriteLine("Сейчас ведь НОЯБРЬ, не так ли?");
                    break;
                case 12:
                    Console.WriteLine("Сейчас ведь ДЕКАБРЬ, не так ли ?");
                    break;
                default:
                    Console.WriteLine("Скорее всего вы ввели не подходящее значение или полную чушь...");
                    break;
            }
            Console.Read(); 
        }
    }
}
