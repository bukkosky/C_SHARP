using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                Greetings();

                Age();

                Settings();

            }
        }

        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        private static void Age()
        {
            Console.Write("Wpisz ile masz lat ");
            int age;

            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jesteś Pełnoletni ");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadzono nieprawiłdowy wiek ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jesteś niepełnoletni ");
            }
        }

        private static void Greetings()
        {
            Console.Write("Wpisz swoje imię ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj " + name);
        }
    }
}
