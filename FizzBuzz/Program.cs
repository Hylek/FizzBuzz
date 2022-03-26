using System;

namespace FizzBuzz
{
    internal static class Program
    {
        private const int MaxCount = 100;

        public static void Main(string[] args)
        {
            FizzBuzz(3, 5);
        }

        private static void FizzBuzz(int firstMultiple, int secondMultiple)
        {
            firstMultiple = Math.Abs(firstMultiple);
            secondMultiple = Math.Abs(secondMultiple);
        
            for (var i = 1; i <= MaxCount; i++)
            {
                var fizzBuzz = "";
                if (i % firstMultiple == 0)
                {
                    fizzBuzz += "Fizz";
                }
                if (i % secondMultiple == 0)
                {
                    fizzBuzz += "Buzz";
                }
                if (fizzBuzz.Length <= 0)
                {
                    fizzBuzz = i.ToString();
                }
                Console.WriteLine(fizzBuzz);
            }
        }
    }
}