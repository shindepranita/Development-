using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_without_thirdVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2= 20;
            int num3 = 0;
            Console.WriteLine("before swapping, value of variable 1 is= " + num1 + " and value of variable 2= " + num2);
            num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("After swapping, value of variable 1 is= " + num1 + " and value of variable 2= " + num2);
            Console.ReadLine();

        }
    }
}
