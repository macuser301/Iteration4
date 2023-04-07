using System;

namespace Iteration4
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            //Write a method that will print to the console numbers 3 through 999 by 3 each time
        }
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }

            //Write a method to accept two integers as parameterss and check whether they are equal or not
        }
        public static bool CounterTwo(int a, int b)
        {
            var check = (a == b) ? true : false;
            return check;

        }   //Write a method to check whether a given number is even or odd
        public static void IsNumberEven()
        {

            Console.WriteLine("Enter a number :");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 % 2 == 0)
            {
                Console.WriteLine("Even");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Odd");
                Console.Read();
            }
        }


        //Write a method to check whether a given number is positive or negative
        public static void IsNumberPositive()
        {
            Console.WriteLine("Choose another number.");
            var i = 1;
            var positiveMessage = "You're not positive. Hmmm...";
            if (0 > 5)
            {
                positiveMessage = "You are Positive!";
            }
            Console.WriteLine(positiveMessage);

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static bool AgeChecker()
        {

            Console.WriteLine("Hello, How old are you?");
            //int userAge = int.Parse(Console.ReadLine());
            var age = Console.ReadLine();
            var couldParseAge = int.TryParse(age, out int userAge);
            bool oldEnough;
            if (userAge < 18)
            {
                Console.WriteLine("Sorry your not old enough to vote.");
                oldEnough = false;
            }
            else
            {
                Console.WriteLine("Congratulation's you are old enough to vote. Please step to ballet box.");
                oldEnough = true;
            }
            return oldEnough;


        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool Range()
        {
            Console.WriteLine("Choose a number.");
            int num3 = int.Parse(Console.ReadLine());
            if (num3 >= -10 && num3 <= 10)
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }

        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Multiply(int num)
        {
            for (var i = 1; i <= 12; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }


        }

                 //Call the methods to test them in the Main method below    


        static void Main(string[] args)
        {
            
            PrintThousand();
            Threes();
            Console.WriteLine(CounterTwo(52, 34));
            IsNumberEven();
            IsNumberPositive();
            AgeChecker();
            Range();
            Multiply(6);
            Console.WriteLine("Hello World!");



        }
    }
}
