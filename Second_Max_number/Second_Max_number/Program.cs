using MaxNumber.Application;
using System;

namespace Second_Max_number
{
    internal  class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[] { 5, 8, 9, 6, 12, 8 };
            var numberProcessor = new NumberProcessor();
            var secondMaxNumber = numberProcessor.FindSecondMaxNumber(arrayOfNumbers);
            Console.WriteLine(secondMaxNumber);
            Console.ReadLine();

        }
    }
}
