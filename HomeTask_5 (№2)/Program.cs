using System;
using System.IO;


/*
 * Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
 */
namespace HomeTask_5___2_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим новую директорию, если таковая отсутствует.
            if (!Directory.Exists(@"..\..\..\NewDir"))
                Directory.CreateDirectory(@"..\..\..\NewDir");
            // Сохраним путь к файлу в строковую переменную для удосбства.
            string path = @"..\..\..\NewDir\startup.txt";
            // Вызов функции.
            AppEndDate(path);
        }
        // Данная функция дописыват в файл текущее время.
        static void AppEndDate(string path)
        {
            // Добавим некоторое содержимое в файл.
            File.WriteAllText(path, "Hello! Now: ");
            // Вывод изначального содержимого файла на консоль.
            Console.WriteLine($"Изначальное содержимое файла: {File.ReadAllText(path)}");
            // Дописывание в конец файла текущего времени.
            File.AppendAllText(path, DateTime.Now.ToString("T"));
            // Вывод итогового содержиммого на консоль.
            Console.WriteLine($"Итоговое содержимое файла: {File.ReadAllText(path)}"); 

        }
    }
}
