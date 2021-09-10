using System;

/*
 * Написать метод по определению времени года, где на вход подается число - 
 * порядковый номер месяца. 
 */
namespace HomeTask_4___3_
{
    class Program
    {
        public enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца(число от 1 до 12): ");
            int monthNumber = int.Parse(Console.ReadLine()); // Переменная хранит номер месяца. 
            int seasonNumber = GetMonthNumber(monthNumber); // Перемнная хранит номер времени года из enum.
            PrintSeason(seasonNumber);
            Console.Read();

        }
        // Функция, возвращающая значение из enum, взависимости от номера месяца.
        static int GetMonthNumber(int num)
        {
            if (num <= 2)
                return (int)Seasons.Winter;
            else if (3 <= num && num <= 5)
                return (int)Seasons.Spring;
            else if (6 <= num && num <= 8)
                return (int)Seasons.Summer;
            else if (9 <= num && num <= 12)
                return (int)Seasons.Autumn;
            else
                return -1;
        }
        // Функция вывод название времени года в консоль.
        static void PrintSeason(int sNum)
        {
            switch (sNum)
            {
                case 0:
                    Console.WriteLine("ЗИМА");
                    break;
                case 1:
                    Console.WriteLine("ВЕСНА");
                    break;
                case 2:
                    Console.WriteLine("ЛЕТО");
                    break;
                case 3:
                    Console.WriteLine("ОСЕНЬ");
                    break;
                default:
                    Console.WriteLine("Ошибка: вводите число от 1 до 12 !");
                    break;
            }
        }
    }
}
