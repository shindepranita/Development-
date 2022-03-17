using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_and_Helping_innocent_people
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Tag");
            string s = Console.ReadLine();
            int i, x;

            int flag1 = 0, flag2 = 0;
            for (i = 0; i < 9; i++)
            {
                if ((s[0] + s[1]) % 2 == 0 && (s[3] + s[4]) % 2 == 0 && (s[4] + s[5]) % 2 == 0
                     && (s[7] + s[8]) % 2 == 0)
                {
                    flag1 = 1;
                }
                if (s[2] == 'A' || s[2] == 'E' || s[2] == 'I' || s[2] == 'O' || s[2] == 'U' || s[2] == 'Y')
                    flag2 = 1;
            }
            if (flag1 == 1 && flag2 == 1)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");

            }
            // Console.WriteLine("Press enter to close...");
            Console.ReadKey();
        }
    }
}
