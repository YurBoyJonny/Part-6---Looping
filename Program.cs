using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Part_6___Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuInput;
            do
            {
                Console.WriteLine("Enter 1 for PROMPTER, 2 for PERCENT PASSING, 3 for ODD SUM, or 4 for RANDOM NUMBERS");
                while (!Int32.TryParse(Console.ReadLine(), out menuInput)) ;
                if (menuInput == 1)
                {
                    Prompter();
                }
                if (menuInput == 2)
                {
                    PercentPassing();
                }
                if (menuInput == 3)
                {
                    OddSum();
                }
                if (menuInput == 4)
                {
                    RandomNumbers();
                }
            } while (menuInput < 1 || menuInput > 4);
            Console.ReadLine();
        }
        public static void Prompter()
        {
            Console.WriteLine("---PROMPTER---");
            Thread.Sleep(500);
            Console.WriteLine("Enter a min value");
            int minValue;
            int maxValue;
            while (!int.TryParse(Console.ReadLine(), out minValue)) ;
            do
            {
                Console.WriteLine("Enter a max value");
                while (!int.TryParse(Console.ReadLine(), out maxValue)) ;
            } while (maxValue <= minValue);
            int numberBetween;
            do
            {
                Console.WriteLine("Enter a number in between " + minValue + " and " + maxValue);
                while (!int.TryParse(Console.ReadLine(), out numberBetween));
            } while (numberBetween <= minValue || numberBetween >= maxValue);
            Console.WriteLine($"You said {numberBetween}!");
        }
        public static void PercentPassing()
        {
            Console.WriteLine("---PERCENT PASSING---");
            Console.WriteLine("Enter how many scores you want to enter");
            int scoreAmount;
            while(!Int32.TryParse(Console.ReadLine(), out scoreAmount));
            int scorePassed = 0;
            for (int i = 1; i <= scoreAmount; i++)
            {
                Console.WriteLine("Enter your score #" + i);
                int theScore;
                while (!Int32.TryParse(Console.ReadLine(), out theScore)) ;
                if (theScore > 70)
                {
                    scorePassed = scorePassed + 1;
                }
            }
            int scoreAmountPercent = 100 / scoreAmount;
            int scorePassedPercent = scorePassed * scoreAmountPercent;
            Console.WriteLine(scorePassedPercent + "% of scores passed 70");
        }
        public static void OddSum()
        {
            Console.WriteLine("---ODD SUM---");
            {
                int i, numberEntered, sum = 0;
                Console.Write("Enter a number: ");
                Int32.TryParse(Console.ReadLine(), out numberEntered);

                for (i = 1; i <= numberEntered; i += 2)
                {
                    sum += i;
                }
                Console.WriteLine("The sum of all odd numbers between 1 to " + numberEntered + " = " + sum);
            }
        }
        public static void RandomNumbers()
        {
            Console.WriteLine("---RANDOM NUMBERS---");
            int minValue;
            int maxValue;
            Console.WriteLine("Enter a minimum value");
            while (!Int32.TryParse(Console.ReadLine(), out minValue));
            do{
                Console.WriteLine("Enter a maximum value");
                while (!Int32.TryParse(Console.ReadLine(), out maxValue));
            } while (maxValue < minValue);
            Random generator = new Random();
            for (int i = 1; i <= 25; i++)
            {
                int numberBetween = generator.Next(minValue, maxValue + 1);
                Console.WriteLine("Random #" + i + ": " + numberBetween + " ");
                Thread.Sleep(500);
            }
        }
    }
}