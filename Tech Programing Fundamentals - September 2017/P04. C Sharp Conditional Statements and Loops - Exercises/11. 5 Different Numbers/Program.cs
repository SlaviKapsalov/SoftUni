using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber - firstNumber < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int number1 = firstNumber; number1 <= secondNumber; number1++)
                {
                    for (int number2= number1 + 1; number2 <= secondNumber; number2++)
                    {
                        for (int number3 = number2 + 1; number3 <= secondNumber; number3++)
                        {
                            for (int number4 = number3 + 1; number4 <= secondNumber; number4++)
                            {
                                for (int number5 = number4 + 1; number5 <= secondNumber; number5++)
                                {
                                    Console.WriteLine(number1 + " " + number2 + " " + number3 + " " + number4 + " " + number5);
                                }
                            }
                        }
                    }
                } 
               
            }
        }
    }
}
