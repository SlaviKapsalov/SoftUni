using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberMiles = double.Parse(Console.ReadLine());

            double numberKilometers = numberMiles * 1.60934;

            Console.WriteLine($"{numberKilometers:F2}");
        }
    }
}
