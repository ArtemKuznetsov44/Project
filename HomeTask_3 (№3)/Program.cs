using System;

/*
 * Написать программу, выводящую введённую пользователем строку в обратном порядке.
 */
namespace HomeTask_3___3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine(); 
            Console.Write("Введенная строка в обратном порядке: "); 
            ReversePrint(str);
            Console.Read(); 
        }

        static void ReversePrint (string str)
        {
            for(int i = str.Length - 1; i >=0; i--)
            {
                Console.Write(str[i]); 
            }
        }
    }
}
