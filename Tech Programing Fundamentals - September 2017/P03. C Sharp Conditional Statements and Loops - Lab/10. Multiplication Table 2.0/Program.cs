using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstMultiplier = int.Parse(Console.ReadLine());
            int secondMultiplier = int.Parse(Console.ReadLine());

            
            int product;

            if (secondMultiplier > 10)
            {
                product = firstMultiplier * secondMultiplier;
                Console.WriteLine($"{firstMultiplier} X {secondMultiplier} = {product}");
            }
            else
            {
                for (int i = secondMultiplier; i <= 10; i++)
                {
                    product = firstMultiplier * i;
                    Console.WriteLine($"{firstMultiplier} X {i} = {product}");
                }
            }

          
        }
    }
}
