using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_and_profile_picture
{
    internal class Program
    {
        static void Main(string[] args)
        {
				Console.WriteLine("enter length");
				int lenght = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("enter no. of photocopies");
				int noOfPhotocopies = Convert.ToInt32(Console.ReadLine());
				for (int i = 0; i < noOfPhotocopies; i++)
				{
				 Console.WriteLine("enter width and height");
					string[] L3 = Console.ReadLine().Split(' ');
					int Width = Convert.ToInt32(L3[0]);
					int Height = Convert.ToInt32(L3[1]);
					if (Height < lenght || Width < lenght)
						Console.WriteLine("UPLOAD ANOTHER");
					else if (Height == Width)
						Console.WriteLine("ACCEPTED");
					else
						Console.WriteLine("CROP IT");
				}
				Console.ReadLine();
			}
		
		}
    }

