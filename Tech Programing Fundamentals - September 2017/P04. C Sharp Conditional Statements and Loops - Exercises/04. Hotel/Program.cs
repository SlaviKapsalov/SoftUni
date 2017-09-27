using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double pricePerNightForStudio = 0;
            double priceForNightForDouble = 0;
            double priceForNightForSuite = 0;

            if (month == "May" || month == "October")
            {
                pricePerNightForStudio = 50;
                priceForNightForDouble = 65;
                priceForNightForSuite = 75;
            }
            else if (month == "June" || month == "September")
            {
                pricePerNightForStudio = 60;
                priceForNightForDouble = 72;
                priceForNightForSuite = 82;
            }
            else  if (month == "July" || month == "August" || month == "December")
            {
                pricePerNightForStudio = 68;
                priceForNightForDouble = 77;
                priceForNightForSuite = 89;
            }

            if (nightsCount > 7 && (month == "May" || month == "October"))
            {
                pricePerNightForStudio = 50 * 0.95;
            }

            if (nightsCount > 14 && (month == "June" || month == "September"))
            {
                priceForNightForDouble = 72 * 0.9;
            }

            if (nightsCount > 14 && (month == "July" || month == "August" || month == "December"))
            {
                priceForNightForSuite = 89 * 0.85;
            }

            double priceForSudio = pricePerNightForStudio * nightsCount;
            double priceForDouble = priceForNightForDouble * nightsCount;
            double priceForSuite = priceForNightForSuite * nightsCount;

            if (nightsCount > 7 && (month == "October" || month == "September"))
            {
                priceForSudio -= pricePerNightForStudio;
            }

            Console.WriteLine($"Studio: {priceForSudio:F2} lv.");
            Console.WriteLine($"Double: {priceForDouble:F2} lv.");
            Console.WriteLine($"Suite: {priceForSuite:F2} lv.");
        }
    }
}
