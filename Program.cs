using System;

namespace assignment1_part3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            do
            {
                Console.WriteLine("\nEnter name of new person below");
                Console.Write("First name: ");
                var fname = Console.ReadLine();
                Console.Write("Last name: ");
                var lname = Console.ReadLine();
                var user = new Person(fname, lname);

                Console.WriteLine("\nCreating new person record...");
                
                // gets year input from method below
                user.YearOfBirth = YearInput();

                Console.WriteLine(user.PersonInfo());

                // uses method below to see if the user wants to continue
                input = Continue();

            } while (input == "Y");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        public static string Continue()
        {
            var input = "";
            do
            {
                Console.WriteLine("\nDo you want to enter another person? (y/n)");
                input = Console.ReadLine().ToUpper();
                if (input != "N" && input != "Y")
                {
                    Console.WriteLine("Invalid input");
                }
            } while (input != "N" && input != "Y");

            return input;
        }

        public static int YearInput()
        {
            var year = 0;
            var isNum = true;
            do
            {
                Console.Write("Enter year of birth: ");
                var yearInput = Console.ReadLine();
                isNum = int.TryParse(yearInput, out year);
                if (!isNum || year < 1800 || year > DateTime.Now.Year)
                {
                    Console.WriteLine("Invalid input");
                }
            } while (!isNum || year < 1800 || year > DateTime.Now.Year);
            return year;
        }
    }
}
