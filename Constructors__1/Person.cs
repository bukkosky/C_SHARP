using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors__1
{
    class Person
    {
        int id;
        string firstName;
        string lastName;
        string adress;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            firstName = "Marcin";
            lastName = "Kowal";
            age = 14;
            gender = "Male";
        }

        public Person(int id, string firstName, string lastName, string adress, int age, string gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.adress = adress;
            this.age = age;
            this.gender = gender;
        }

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            adress = "Szczecin";
            age = 18;
        }

        public Person(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }
    }
}
