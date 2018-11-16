using System;

namespace Constructors__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person(1, "Tomek");
            Person person3 = new Person(2, "Marek", "Nowak");
            Person person4 = new Person(5, "Jan", "Kowalski", "Katowice", 20, "Male");
        }
    }
}
