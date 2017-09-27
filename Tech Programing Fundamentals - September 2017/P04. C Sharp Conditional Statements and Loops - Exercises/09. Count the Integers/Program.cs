using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int numberOfNumbers = 0;
            bool notIsANumber = false;

            for (int i = 0; i <= 100; i++)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    numberOfNumbers++;
                }
                catch (Exception)
                {
                    notIsANumber = true;
                    break;
                }
            }

            if (notIsANumber)
            {
                Console.WriteLine(numberOfNumbers);
            }
            
        }
    }
}
