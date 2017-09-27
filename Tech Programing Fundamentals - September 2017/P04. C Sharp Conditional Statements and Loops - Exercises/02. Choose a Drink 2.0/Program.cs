using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double priceForWater = 0.7 * quantity;
            double priceForCoffee = 1 * quantity;
            double priceForBeer = 1.7 * quantity;
            double priceForTea = 1.2 * quantity;

            string other = profession;
            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The Athlete has to pay {priceForWater:F2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The Businessman has to pay {priceForCoffee:F2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The Businesswoman has to pay {priceForCoffee:F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The SoftUni Student has to pay {priceForBeer:F2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {priceForTea:F2}.");
                    break;
            }
        }
    }
}
