using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int firstNumber;
            int secondNumber = 0;
            int countOfCombination = 0;
            bool isEqual = false;

            for (firstNumber = m; firstNumber >= n; firstNumber--)
            {
                for (secondNumber = m; secondNumber >= n; secondNumber--)
                {
                    countOfCombination++;
                    if (firstNumber + secondNumber == magicNumber)
                    {
                        isEqual = true;
                        break;
                    }
                }
                if (isEqual)
                {
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{countOfCombination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
