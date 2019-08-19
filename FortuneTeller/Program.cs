using System;

namespace FortuneTeller
{
    class Program
    {
        private static int birthMonth;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Fortune Teller");

            Console.WriteLine("What is your first name?");

            string firstName = Console.ReadLine();

            Console.WriteLine("Hello," + firstName);

            Console.WriteLine("What is your age?");
            //if age is odd they retire in 1 year else if age is even they retire in 2 years

            int age = Convert.ToInt32(Console.ReadLine());
            string retirementYears;

            if (age % 2 == 0)
            {
                retirementYears = "2 years";
            }else{
                retirementYears = "1 year";
            }

            Console.WriteLine($"your age is {age}");

            string bankBalance;
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankBalance = "$300,000";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankBalance = "$3,000,000";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bankBalance = "$300,000,000";
            }

            string whatColor;
            string transportation;
            do
            {
                Console.WriteLine("what is your favorite ROYGBIV color? if you're unsure type \'help\'");
                whatColor = Console.ReadLine().ToLower();

                switch (whatColor)
                {
                    case "red":
                        transportation = "racecar";
                        break;
                }
                
              
                switch (whatColor)
                {
                    case "orange":
                        transportation = "oxen";
                        break;
                }
                switch (whatColor)
                {
                    case "yellow":
                        transportation = "yacht";
                        break;
                }
                switch (whatColor)
                {
                    case "green":
                        transportation = "glider";
                        break;
                }
                switch (whatColor)
                {
                    case "blue":
                        transportation = "blimp";
                        break;

                }
                switch (whatColor)
                {
                    case "indigo":
                        transportation = "inflatable";
                        break;

                }
                switch (whatColor)

                {
                    case "violet":
                        transportation = "van";
                        break;

                }

                Console.WriteLine("How many siblings do you have?");
                //if number of siblings is
            int siblings = Convert.ToInt32(Console.ReadLine());
                string numberofsiblings;

                if (siblings % == 1)

                {
                    numberofsiblings = "1 sibling";

                }
                else { }














                Console.WriteLine($"{firstName} will retire with " + bankBalance +  " in the bank.");

            Console.ReadLine();

        }
    }
}
            
