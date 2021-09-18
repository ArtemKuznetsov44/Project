using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace HomeTask_6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ConsoleKeyInfo X; // Переменная, которая хранит в себе нажатую пользователем клавишу.
            do
            {
                Console.Clear(); // Очищаем консоль.
                Process[] processes = Process.GetProcesses(); // Получаем наши процессы. 
                PrintProcceses(processes); // Вызов функции. 
                Console.WriteLine();
                Console.WriteLine("================================================================================================================");
                Console.WriteLine("1. Завершить процесс по его Id.");
                Console.WriteLine("2. Завершить процесс по его имени.");
                X = Console.ReadKey(); // Принимаем клавишу, которо. нажал пользователь.
                try
                {
                    switch (X.Key)
                    {
                        case ConsoleKey.D1: // При нажатии "1".
                            Console.WriteLine();
                            Console.Write("Введите Id: ");
                            DelById(processes);
                            break;
                        case ConsoleKey.D2: // При нажатии "2".
                            Console.WriteLine();
                            Console.Write("Введите название процесса: ");
                            DelByName(processes);
                            break;
                    }
                }
                catch(Exception e) // Ловим возможные исключения и выводим их на консоль. 
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Нажмите Enter для продолжения...");
                    Console.Read();
                }
            }
            while (X.Key != ConsoleKey.Escape); // Условие выхода их цикла - пока не нажата клавиша Escape.
        }
        // Данная функция отвечает за вывод всех процессов на консоль в читаемом формате.
        static void PrintProcceses(Process[] processes) 
        {
            int counter = 1;
            int maxLenght = GetMaxLength(processes); 
            foreach (Process process in processes)
            {
                string str = $"Name: {process.ProcessName} Id:{process.Id}";
                if (str.Length < maxLenght)
                {
                    string space = "";
                    for (int i = 0; i < maxLenght - str.Length; i++)
                        space += " ";
                    str += space;
                }
                Console.Write($"{str}{(counter % 2 == 0 ? "\n" : "\t")}");
                counter++;
            }
        }
        // Данная функция получает макисмально возможную длину для строки, что позволяет откорректировать вывод в консоль.
        static int GetMaxLength(Process[] processes)
        {
            int maxLenght = 0;
            foreach (Process process in processes)
            {
                string str = $"Name: {process.ProcessName} Id:{process.Id}";
                if (str.Length > maxLenght)
                    maxLenght = str.Length;
            }
            return maxLenght;
        }
        // Данная функция завершает процесс по его id, которое вводит пользователь. 
        static void DelById( Process[] processes)
        {
            string idString = Console.ReadLine(); 
            idString = idString.Trim();
            int ID = int.Parse(idString);
            bool flag = false; 
            foreach(Process process in processes)
            {
                if(process.Id == ID)
                {
                    process.Kill();
                    flag = true; 
                } 
            }
            if (!flag)
                Console.WriteLine("Процесса с таким id не существует."); 
        }
        // Данная функция завершает процесс по его имени, которое ввел пользователь. 
        static void DelByName(Process[] processes)
        {
            string nameOfProcess = Console.ReadLine(); // Не известная мне ерунда здесь происходила, а именно при повторном обращении к данной функции без этой
                                                       // максимально тупой проверки компилятор просто проскакивает ввод данных для пользователя.
                                                       // Поэтому здесь присутсвует максимально странный if.

            if (nameOfProcess == "")
                nameOfProcess = Console.ReadLine(); 
            nameOfProcess = nameOfProcess.Trim();
            bool flag = false; 
            foreach(Process process in processes)
            {
                if(process.ProcessName == nameOfProcess)
                {
                    process.Kill();
                    flag = true; 

                }
            }
            if (!flag)
                Console.WriteLine("Процесса с таким названием не существует."); 
        }
    }
}
