using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int sum = 0;
            int numberOfCombination = 0;

            for (int firstCombination = n; firstCombination >= 1; firstCombination--)
            {
                for (int secondCombination = 1; secondCombination <= m; secondCombination++)
                {
                    numberOfCombination++;
                    sum += 3 * (firstCombination * secondCombination);

                    if (sum >= maxSum)
                    {
                        break;
                    }
                }
                if (sum >= maxSum)
                {
                    break;
                }
            }
            if (sum >= maxSum)
            {
                Console.WriteLine($"{numberOfCombination} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{numberOfCombination} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
