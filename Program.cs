using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.4, 5, 0.333 };

            int i = 0;
            double result = 0;
            foreach (var number in numbers)
            {
                i++;
                result += number;
                Console.WriteLine($"Number {i} = " + number + " Actual result = " + result);

            }


            var numbers2 = new List<double>() { 12.4, 5, 0.333 };


            if (args.Length > 0)
            {
                Console.WriteLine("Hello " + args[0]);

            }
            else
            {
                Console.WriteLine("Nie podano argumentu do wyświetlenia !");
            }

        }
    }
}
