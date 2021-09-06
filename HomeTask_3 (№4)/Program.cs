using System;

/*
 * «Морской бой»: вывести на экран массив 10х10, 
 * состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
 */

namespace HomeTask_3___4_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Двумерный массив 10х10, хронящий в себе символы, описывающие игровое поле.
            char[,] playingField = { { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                                     { 'O', 'X', 'O', 'X', 'X', 'X', 'X', 'O', 'O', 'O' },
                                     { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                                     { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'X', 'X', 'X' },
                                     { 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O' },
                                     { 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O' },
                                     { 'O', 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'X', 'O' },
                                     { 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'X', 'O' },
                                     { 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O' },
                                     { 'O', 'X', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },};
            Console.WriteLine("Поле для игры в морской бой:");
            Console.WriteLine(); 
            // Данная функция отвечает за вывод игрового поля.
            PrintPlayingField(playingField);
            Console.WriteLine(); 
            // Функция, выводящая поясние.
            Instruction(); 
            Console.Read();
        }
        static void PrintPlayingField(char[,] playingFiled)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write(playingFiled[i, j] + " ");
                }
                Console.WriteLine(); 
            }
        }
        static void Instruction()
        {
            Console.WriteLine("X - элементы кораблей.\n" +
                "O - пустые клетки."); 
        }
    }
}
