using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOddNumbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 1;

            for (int i = 1; i <= numberOddNumbers; i++)
            {
                sum += number;
                Console.WriteLine(number);
                number += 2;
                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
