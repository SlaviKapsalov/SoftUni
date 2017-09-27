using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
         
            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    if (n < 0)
                    {
                        Console.WriteLine($"The number is: {n * (-1)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"The number is: {n}");
                        break;
                    }
                }
            }
        }
    }
}
