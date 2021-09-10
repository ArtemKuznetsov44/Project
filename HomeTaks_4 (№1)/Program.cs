using System;

/*
 * Написать метод GetFullName(string firstName, string lastName, string patronymic),
 * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
 */

namespace HomeTaks_4___1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите фамилию: ");
            string firstName = Console.ReadLine(); // Запись фамилии в перемнную.
            Console.Write("Введите имя: ");
            string lastName = Console.ReadLine();  // Запись имени в переменную.
            Console.Write("Введите отчество: "); 
            string patronymic  = Console.ReadLine(); // Запись отчества в переменную.
            Console.WriteLine();
            // Вызов функции, которая объединяет все три созданные выше переменные в единое ФИО,
            // а также вывод результата в консоль.
            Console.WriteLine($"Ваше полное имя: {GetFullName(firstName, lastName, patronymic)}");
            Console.Read(); 
        }
        // Функция для объединения подстрок в единую строку.
        static string GetFullName(string fN, string mN, string p)
        {
            string fullName = fN + " " + mN + " " + p; // Конкатенация строк.
            return fullName; 
        }
    }
}
