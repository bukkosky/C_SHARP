using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Part_10
{
    class Diary
    {

        public Diary()
        {
            ratings = new List<float>();
        }

        List<float> ratings;

        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {

            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count;

            return avg;
        }

        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
