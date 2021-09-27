using System;

namespace HomeTask_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string rightPassword = "password"; 
            Console.Write("Введите пароль: ");
            if (Console.ReadLine() != rightPassword)
            {
                Console.WriteLine("Не верный пароль!");
                Console.Read(); 
            }
            else
            {
                Console.Write("Введите первое целое число: ");
                int value1 = int.Parse(Console.ReadLine()); // - 1 число. 
                Console.Write("Введите второе целое число: ");
                int value2 = int.Parse(Console.ReadLine()); // - 2 число. 
                Console.Write("Введите символ операции: ");
                char oper = char.Parse(Console.ReadLine()); // - получение символа операции.
                int result = Operation(value1, value2, oper); // - сохрание результата в переменную.
                Console.WriteLine(($"Результат: {result}"));
            }
        }
        static int Operation(int value1, int value2, char oper)
        {
            switch (oper)
            {
                case '+':
                    return (value1 + value2);
                case '-':
                    return (value1 - value2);
                case '*':
                    return (value1 * value2);
                case '/':
                    return (value1 / value2);
                default:
                    Console.WriteLine("К сожалению, введенная Вами операция не распознана (");
                    return -1;
            }
        }
    }
}
