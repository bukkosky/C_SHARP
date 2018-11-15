using System;

namespace Student_Diary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1-10 ");

                float rating; 
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if (rating == 11)
                {
                    break;
                }

                if (result)
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowa liczba, oczekiwana od 1 do 10 ");
                    }
                }
            }
            Console.WriteLine("średnia ocen to: " + diary.CalculateAverage());
            Console.WriteLine("najwyższa ocena to: " + diary.GiveMaxRating());
            Console.WriteLine("najniższa ocena: " + diary.GiveMinRating());
            Console.ReadKey();
        }
    }
}
