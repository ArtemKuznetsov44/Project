using System;

/*
 * Написать программу, выводящую элементы двухмерного массива по диагонали.
 */

namespace HomeTask_3___1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерности двумерного массива:");

            // Получаем кол-во строк для нашего массива.
            Console.Write("Кол-во строк: "); 
            int rows = int.Parse(Console.ReadLine());

            // Получаем кол-во столбцов для нашего массива.
            Console.Write("Кол-во столбцов: "); 
            int columns = int.Parse(Console.ReadLine());

            // Создаем двумерный целочисленный массив.
            int[,] array = new int[rows, columns];
            
            // Вызываем функцию, которая будет заполнять наш массив случаныйми числами.
            Zap(array, rows, columns); 

            // Вызываем функцию, которая будет выводить все элементы двумерного массива по диагонали.
            Print(array, rows, columns);

            Console.Read(); 
            
        }
        static void Print(int[,] array, int rows, int columns)
        {
            string str = ""; 
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(str + array[i, j].ToString());
                    str += ">"; // В качестве наглядности, вместо пробела в данном выводе установил знак "больше".
                }
            }
            Console.WriteLine();
            Console.WriteLine("А теперь в другую сторону:");
            int SIZE = array.Length; 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    string space = "";
                    while (space.Length != SIZE - 1 )
                    {
                        space += "<"; // В качестве наглядности,
                                      // вместо пробела в данном выводе установил знак "меньше".
                    }
                    SIZE -= 1;
                    Console.WriteLine(space + array[i, j].ToString()); 
                }
            }
        }
        static int[,] Zap(int[,] array, int rows, int columns)
        {
            // Класс Random служит для генерации случайных чисел.
            // Создадим экземпляр данного класса.
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // В каждую "ячейку" добавляется случаной сгенерированное число от 10 до 100.
                    array[i, j] = rnd.Next(10, 100);
                }
            }
            // Возвращаем заполненный данными двумерный массив. 
            return array; 
        }
    }
}
