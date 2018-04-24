using System;

namespace assignment1_part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of new person below");
            Console.Write("First name: ");
            var fname = Console.ReadLine();
            Console.Write("Last name: ");
            var lname = Console.ReadLine();
            var user = new Person(fname, lname);

            Console.WriteLine("\nCreating new person record...");
            Console.Write("Enter year of birth: ");
            user.YearOfBirth = int.Parse(Console.ReadLine());


            Console.WriteLine($"\nPerson: {user.GetFullName()} is {user.GetAge()} years old");
        }
    }
}
