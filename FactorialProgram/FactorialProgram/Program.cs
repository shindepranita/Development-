using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, factorial = 1;
            Console.WriteLine(" Enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                factorial = factorial * i;

            Console.Write("factorial of " + num + " is= " + factorial);
            Console.ReadLine();
        }
    }
}
