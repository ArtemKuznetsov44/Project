using System;
using System.Collections.Generic;
using System.IO; 
/*
 * Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
 */
namespace HomeTask_5___3_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим новую директорию в случае ее отсутствия.
            if (!Directory.Exists(@"..\..\..\WorkDir"))
                Directory.CreateDirectory(@"..\..\..\WorkDir");
            // Сохраним путь в строковую переменную для удобства.
            string path = @"..\..\..\WorkDir\file.bin"; 
            Console.Write("Введите произвольный набор чисел от 0 до 255, разделяя числа пробелом: ");
            string data = Console.ReadLine(); // Сохраняем данные, которые вводит пользователь.

            // Вызов функции "проверки", которая принимает в качестве параметров: путь и проверенный List<byte>.
            Writing(path, Verification(data));
            Console.WriteLine("В файл были записаны лишь подходящие числа!");
            Console.Write("Содежимое файла: ");
            // Вывод содержимого файла в консоль с помощью функции. 
            Print(path); 
            Console.Read(); 
        }

        // Данная функция проверяет правильность введынных пользователем данных,
        // и оставльет лишь подходящие значения.
        static List<byte> Verification(string data)
        {
            data = data.Trim(); // Удаляем лишнии пробелы, если они существуют.
            string[] unverifiedNumbers = data.Split(); // Сохраняем данные в строковой массив.

            List<byte> verifiedNumbers = new List<byte>(); // Создаем лист, в который
                                                           // будут размещеные лишь подходящие значения.
            foreach(string value in unverifiedNumbers)
            {
                // Проверка на соответствие типу byte.
                if (int.Parse(value) < 255)
                    verifiedNumbers.Add(byte.Parse(value));
            }
            // Возврат "верного" листа.
            return verifiedNumbers; 
        }
        // Функция выполняет запись данных в файл.
        static void Writing(string path, List<byte> verifiedNumbers)
        {
            File.WriteAllBytes(path, verifiedNumbers.ToArray());
        }
        // Функция выполняет вывод содежимого файла, для наглядности и проверки работоспособности кода.
        static void Print(string path)
        {
            byte[] numbers = File.ReadAllBytes(path); 
            foreach (byte value in numbers)
            {
                Console.Write(value.ToString() + " "); 
            }
        }
    }
}
