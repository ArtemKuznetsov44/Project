// Decompiled with JetBrains decompiler
// Type: HomeTask_7.Program
// Assembly: HomeTask_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A3D30124-A47C-4DDB-890A-C15B0E55DB49
// Assembly location: C:\Users\Artem\Desktop\HomeTask_7\bin\Release\net5.0\HomeTask_7.dll

using System;

namespace HomeTask_7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string str = "password";
            Console.Write("Введите пароль: ");
            if (Console.ReadLine() == str)
            {
                Console.WriteLine("Вы угадали пароль, но лучше введите неверный )");
                Console.Read();
            }
            else
            {
                Console.Write("Введите первое целое число: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Введите второе целое число: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.Write("Введите символ операции: ");
                char ch = char.Parse(Console.ReadLine());
                int num3 = num2;
                int num4 = (int)ch;
                Console.WriteLine(string.Format("Результат: {0}", (object)Program.Operation(num1, num3, (char)num4)));
            }
        }

        private static int Operation(int value1, int value2, char oper)
        {
            switch (oper)
            {
                case '*':
                    return value1 * value2;
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '/':
                    return value1 / value2;
                case '%':
                    return value1 % value2;
                default:
                    Console.WriteLine("К сожалению, введенная Вами операция не распознана (");
                    return -1;
            }
        }
    }
}
