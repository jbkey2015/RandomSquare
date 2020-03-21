using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var randomNums = new List<int>();
            var squaredNums = new List<int>();
            for (int i = 0; i < 21; i++)
            {
                var randomNum = random.Next(51);
                randomNums.Add(randomNum);
                squaredNums.Add(randomNum * randomNum);
            }
            Console.WriteLine($"Random Numbers: {String.Join(", ", randomNums)}");
            Console.WriteLine($"Squared Random Numbers: {String.Join(", ", squaredNums)}");

            var noOddSquaredNums = new List<int>();

            foreach (var number in squaredNums)
            {
                if (number % 2 == 0)
                {
                    noOddSquaredNums.Add(number);
                }
            }

            Console.WriteLine($"Squared with no odds: {String.Join(", ", noOddSquaredNums)}");

            Console.ReadLine();
        }
    }
}
