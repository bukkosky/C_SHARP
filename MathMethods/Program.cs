using System;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(10));

            Console.WriteLine(Math.Dodaj(1,2,3,4));

            Console.WriteLine(Math.Poteguj(2,3));

            Console.ReadLine();
        }
    }
}


class Math
{
    public static int Abs(int x)
    {
        if (x < 0)
        {
            return x * (-1);
        }
        else return x;
    }

    public static int Dodaj(params int[]args)
    {
        int suma = 0;

        for (int i = 0; i < args.Length; i++)
        {
            suma += args[i];
        }

        return suma;
    }

    public static int Poteguj(int podstawa_potegi, int wykladnik = 2)
    {
        int tmp = 1;

        for (int i = 0; i < wykladnik; i++)
        {
            tmp *= podstawa_potegi;
        }

        return tmp;
    }
}
