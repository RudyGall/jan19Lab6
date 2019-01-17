using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace jan19Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            bool runP = true;
            int sides;
            bool rOLL;
            int d1;
            int d2;
            string firstName = nameValid();
            Console.Clear();
            Console.WriteLine("Hello {0}, Welcome to take 1 on my dice roll app", firstName);
            rOLL = RollTheDice();
            while (runP == true)
            {               
                sides = SideTheDice();              
                d1 = RandomTheNumbers(sides, random);
                d2 = RandomTheNumbers(sides, random);
                Console.WriteLine("\nThe result of your first die is {0} and the result of your second die is {1}", d1, d2);
                runP = Continue();
            }
        }
        public static bool RollTheDice()
        {
            Console.WriteLine("Would you like to roll the dice? (Y or N)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool rOLL;
            if (input == "y")
            {
                rOLL = true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Thank you, Goodbye!");
                Console.ReadLine();
                rOLL = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                rOLL = Continue();
            }
            return rOLL;
        }
        public static int SideTheDice()
        {
            Console.WriteLine("\nHow many sides should each die have?");
            int.TryParse(Console.ReadLine(), out int sides);
            return sides;
        }
        public static int RandomTheNumbers(int sides, Random random)
        {
           return random.Next(1, sides);
        }
        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to roll again? (Y or N)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Thank you, Goodbye!");
                Console.ReadLine();
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }
        public static string nameValid()
        {
            bool responseValid = true;
            string firstName = "";
            while (responseValid)
            {
                Console.WriteLine("Please enter your first name");
                firstName = Console.ReadLine();

                if (!Regex.IsMatch(firstName, @"^[A-Z]+[A-z]{2,30}$"))
                {
                    Console.WriteLine("I'm sorry, this is not a valid name");
                }
                else
                {
                    Console.WriteLine("Name is valid");
                    break;
                }
            }
            return firstName;
        }
    }
}