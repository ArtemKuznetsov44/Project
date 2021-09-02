using System;
using System.Collections.Generic;

/*
 * Схематично нарисованный чек.
 */
namespace HomeTask_2___4_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем дату и время в переменную подходящего типа.
            DateTime dateTime = new DateTime(2021, 8, 30, 18, 30, 54);
            Console.Write("Введите название посещенного Вами магазина: ");
            string shopName = Console.ReadLine();
            Console.WriteLine(); 
            // Используем словарь для хранение пары: ключ - тип string(наименование товара),
            // значение - тип decimal(цена товара).
            Dictionary<string, decimal> products = new Dictionary<string, decimal>(); 
            // Данная функция будет отвечать за интерактивное заполнение нашего словоря(списка продуктов).
            MakeOurShopList(products);
            // Простой вывод нашего списка с некоторыми дополнениями. 
            Print(products, shopName, dateTime);
            Console.Read(); 
            
        }
        // Интерактивное заполнение словоря - списка продуктов.
        static Dictionary<string, decimal> MakeOurShopList(Dictionary<string, decimal> products)
        {
            // Переменная будет хранить информацию о нажатой клавише.
            ConsoleKeyInfo X;
            do
            {
                Console.WriteLine("Вспомните Ваши покупки, и вводите сначала наименование товара, а затем его стоимость !\n" +
              "Для завершения, нажмите ESCAPE ");
                Console.Write("Ввести наименование продукта: ");
                string name = Console.ReadLine();
                Console.Write("Введите цену продукта: ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Нажмите Enter, чтобы продолжить ввод или ESC для выхода.");
                // После выяснение наименования и цены товара, добавляем его в наш список. 
                products.Add(name, price);
                // Считывание данных о нажатой клавише в переменную.
                X = Console.ReadKey();
                if (X.Key != ConsoleKey.Escape)
                    Console.Clear();         
            } // Чтобы выйти из цикла заполнения списка, нужно нажать ESC.
            while (X.Key != ConsoleKey.Escape);
            // Возвращаем уже готовый словарь(список продуктов).
            return products; 
        }

        static void Print(Dictionary<string, decimal> products, string shopName, DateTime dateTime)
        {
            Console.WriteLine("============================");
            Console.WriteLine("\t" + shopName);
            Console.WriteLine("===========================");
            Console.WriteLine("---------------------------");
            // Данная переменная будет отвечать за хранение общей стоимости получившийся корзины.
            decimal fullPrice = default(decimal); 
            // При помощи цикла проходимся по словарю, попутно выводя его ключи и значения,
            // а также собирая информацию об общем ценнике за корзину.
            foreach(KeyValuePair<string, decimal> keyValue in products)
            {
                Console.WriteLine(keyValue.Key + ":  " + keyValue.Value);
                fullPrice += keyValue.Value; 
            }
            Console.WriteLine();
            // Вывод общей стоимости.
            Console.WriteLine($"\t Итог: {fullPrice}");
            Console.WriteLine("---------------------------");
            // Вывод заданной выше даты и времени.
            Console.WriteLine($"Время: {dateTime}");
            Console.WriteLine("---------------------------");
        }
    }
}
