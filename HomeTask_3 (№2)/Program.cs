using System;

/*
 *  Написать программу «Телефонный справочник»: создать двумерный массив 5х2, 
 *  хранящий список телефонных контактов: первый элемент хранит имя контакта, 
 *  второй — номер телефона/email.
 */

namespace HomeTask_3___2_
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] telDirectory = { { "Иванов Иван", "8-988-233-54-32 | cat@mail.ru" },
                                       { "Федоров Арсений", "8-922-278-23-01 | dog@mail.ru" },
                                       { "Копанцев Дмитрий", "8-973-434-13-88 | pig@mail.ru" },
                                       { "Чугунов Дмитрий", "8-901-879-37-15| | lion@mail.ru" },
                                       { "Новиков Алексей", "8-927-534-24-67 | horse@mail.ru" } };
                                                                                               
            Console.WriteLine("\t\t ТЕЛЕФОННЫЙ СПРАВОЧНИК");
            Print(telDirectory);
            Console.Read(); 
        }
        static void Print(string[,] telDirectory)
        {
            for(int i = 0; i < 5; i++)
            {
                int j = 0; 
                Console.WriteLine($"Name: {telDirectory[i, j]} -> Contacts: {telDirectory[i, ++j]}"); 
            }
        }

    }
}
