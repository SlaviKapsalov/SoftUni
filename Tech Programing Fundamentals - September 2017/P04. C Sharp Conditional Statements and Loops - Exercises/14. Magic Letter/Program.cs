using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (char first = firstLetter; first <= secondLetter; first++)
            {
                for (char second = firstLetter; second <= secondLetter; second++)
                {
                    for (char third = firstLetter; third <= secondLetter; third++)
                    {
                        string result = $"{first}{second}{third} ";
                        if (!result.Contains(thirdLetter))
                        {
                            Console.Write(result);
                        }
                    }
                }
            }


        }
    }
}
