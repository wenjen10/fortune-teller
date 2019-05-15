using System;

namespace FortuneTeller
{
    class Program
    {
        //private static bool month;
        //private static string cout;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Fortune Teller");

            Console.WriteLine("What is your first name?");
            
            string firstName = Console.ReadLine();

            Console.WriteLine("Hello," + firstName);
            Console.WriteLine("What is your last name?");
            Console.WriteLine("What is your age?");

            //ask user for their birth month from 1-12
            Console.WriteLine("What is your birth month?");

            //save birth month in a variable of type string
            string usersBirthMonth = Console.ReadLine();
            string bankBalance = "";

            //if birth month = "1" then bank account = $300,000
            if (usersBirthMonth == "1")
            {
                bankBalance = "$300,000";
            }

            //if birth month = "2" then bank account = $300,000
            //...
            //

            Console.WriteLine(firstName + " will retire with " + bankBalance +  " in the bank.");

        }
    }
}
