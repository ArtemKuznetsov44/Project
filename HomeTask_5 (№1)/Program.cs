using System;
using System.IO; 
/*
 * Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
 */

namespace HomeTask_5___1_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим новую директорию, если таковая отсутствует.
            if (!Directory.Exists(@"..\..\..\NewDir"))
                Directory.CreateDirectory(@"..\..\..\NewDir");
            // Сохраним путь к файлу в строковую переменную для удобства.
            string path = @"..\..\..\NewDir\SomeData.txt"; 
            Console.Write("Введите произвольный набор данных: ");

            string someDate = Console.ReadLine(); // Сохранение данных,
                                                  // которые ввел пользователь в строковую переменную.
            // Вызов функции.
            KeepInFile(someDate, path);
            Console.Read(); 
        }
        // Данная функции отвечает за запись в текстовый файл данных, которые ввел пользователь.
        static void KeepInFile(string data, string path)
        {
            File.WriteAllText(path, data);
            Console.WriteLine("Данные были записаны в файл."); 
        }
    }
}
