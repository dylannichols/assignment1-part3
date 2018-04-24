using System;

namespace assignment1_part3
{
    class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public int YearOfBirth {get; set;}

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int GetAge()
        {

            return DateTime.Now.Year - YearOfBirth;
        }
    }
}
