using System;

/*
 * (*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, 
 * вывести сообщение «Дождливая зима».
 */
namespace HomeTask_2___5_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Здравствуйте! Пожалуйста, введите минимальную сегодняшнюю температуру за сутки: ");
            int maxTemp = int.Parse(Console.ReadLine());
            Console.Write("Сейчас введите максимальную сегодняшнюю температуру: ");
            int minTemp = int.Parse(Console.ReadLine());
            int midDayTemp = (maxTemp + minTemp) / 2; 
            Console.WriteLine();
            Console.Write("Введите порядковый номер текущего месяца: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (count)
            {
                case 1:
                    Console.WriteLine("Сейчас ведь ЯНВАРЬ, не так ли?");
                    if (midDayTemp > 0)
                        Console.WriteLine("Дождливая зима, однако..."); 
                    break;
                case 2:
                    Console.WriteLine("Сейчас ведь ФЕВРАЛЬ, не так ли?");
                    if (midDayTemp > 0)
                        Console.WriteLine("Дождливая зима, однако...");
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
                    if (midDayTemp > 0)
                        Console.WriteLine("Дождливая зима, однако...");
                    break;
                default:
                    Console.WriteLine("Скорее всего вы ввели не подходящее значение или полную чушь...");
                    break;
            }
            Console.Read();
        }
    }
}
