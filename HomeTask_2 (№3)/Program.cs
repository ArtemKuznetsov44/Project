using System;

/*
 * Определить, является ли введённое пользователем число чётным.
 */
namespace HomeTask_2___3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Пожалуйста, введите число для проверки его на четность: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine(); 
            Operation(value);
            Console.Read(); 
        }
        // Данная функция выполняет проверку введенного пользователем числа на верность условию четности.
        static void Operation(int value)
        {
            if (value % 2 == 0)
                Console.WriteLine($"Число {value} является четным!");
            else
                Console.WriteLine($"Число {value} является нечетным!");
        }
    }
}
