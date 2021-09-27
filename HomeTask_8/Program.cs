using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeTask_8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.UserName)
                && Properties.Settings.Default.Age == default(int)
                && String.IsNullOrEmpty(Properties.Settings.Default.Occupation))
            {
                Console.Write("Введите имя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.Write("Введите ваш возраст: ");
                Properties.Settings.Default.Age = int.Parse(Console.ReadLine());
                Console.Write("Опишите совой род деятельности: ");
                Properties.Settings.Default.Occupation = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
                ShowSettings();
            Console.Read(); 
        }
        static void ShowSettings()
        {
            Console.WriteLine(Properties.Settings.Default.Greeting + " " + Properties.Settings.Default.UserName + "!");
            Console.WriteLine($"Ваш возраст {Properties.Settings.Default.Age}");
            Console.WriteLine($"Ваш род деятельности: {Properties.Settings.Default.Occupation}"); 
        }
    }
}
