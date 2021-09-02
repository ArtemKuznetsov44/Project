using System;
/*
 * Запросить у пользователя минимальную и максимальную 
 * температуру за сутки и вывести среднесуточную температуру.
 */
namespace HomeTask_2___1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте! Пожалуйста, введите минимальную сегодняшнюю температуру за сутки: ");
            int maxTemp = int.Parse(Console.ReadLine());
            Console.Write("Сейчас введите максимальную сегодняшнюю температуру: ");
            int minTemp = int.Parse(Console.ReadLine());
            Console.WriteLine("Среднесутчоная температура сегодня равна: " + (maxTemp + minTemp) / 2);
            Console.Read(); 
        }
    }
}
