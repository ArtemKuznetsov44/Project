using System;

// Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 


namespace HomeTask_4___4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите позицию в последовательности Фибоначи: ");
            int position = int.Parse(Console.ReadLine()) - 1; // Сохранение позиции числа с вычетом еденицы
                                                              // что начать подсчет позиции эелмента с 1, а не с 0.
            // Выозов функции, считающей число фибоначи по указанной позиции, и вывод результата в консоль.
            Console.WriteLine($"Число Фибоначи в указанной позиции равно: {GetFibValue(position)}");
            Console.Read(); 
        }
        // Функция, считающая число фибоначи рекурсивно.
        static int GetFibValue(int position)
        {
            if (position == 0 || position == 1)
                return position; 
            else
            {
                return GetFibValue(position - 1) + GetFibValue(position - 2); 
            }
        }
    }
}
