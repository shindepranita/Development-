using System;

namespace ReverseString
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            var stringInput = Console.ReadLine();
            var reversedstring = "";
            int stringlength;

            stringlength = stringInput.Length - 1;

            while (stringlength >= 0)
            {
                reversedstring = reversedstring + stringInput[stringlength];
                stringlength--;
            }
            Console.WriteLine(reversedstring);

            Console.ReadKey();
        }
    }
}
