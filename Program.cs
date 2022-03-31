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

            Prompter();
        }
        public static void Prompter()
        {
            Console.WriteLine("---PROMPTER---");
            Thread.Sleep(700);
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
        }
        public static void PercentPassing()
        { 
        
        }
        public static void OddSum()
        { 

        }
        public static void RandomNumbers()
        { 

        }
    }
}
