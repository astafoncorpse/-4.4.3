using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Роман", 28);
            Console.WriteLine("Моё имя {0}", name);
            Console.WriteLine("Мой возраст {0}", age);

            Console.Write("Ввидите имя: ");
            name = Console.ReadLine();
            Console.Write("Ввидите возраст с цифрами: ");
            age = Convert.ToInt32 (Console.ReadLine());
                

            Console.WriteLine("Ваше имя {0}", name);
            Console.WriteLine("Ваш возраст {0}", age);

            Console.ReadKey();
        }
    }
}
