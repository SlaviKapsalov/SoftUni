using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall = null;
            int priceForHall = 0;

            if (numberOfPeople <= 50)
            {
                hall = "Small Hall";
                priceForHall = 2500;
            }
            else if (numberOfPeople > 50 && numberOfPeople <= 100)
            {
                hall = "Terrace";
                priceForHall = 5000;
            }
            else if (numberOfPeople > 100 && numberOfPeople <= 120)
            {
                hall = "Great Hall";
                priceForHall = 7500;
            }

            double discount = 0.0;
            int priceForServicePackage = 0;

            if (package == "Normal")
            {
                discount = 0.05;
                priceForServicePackage = 500;
            }
            else if (package == "Gold")
            {
                discount = 0.1;
                priceForServicePackage = 750;
            }
            else if (package == "Platinum")
            {
                discount = 0.15;
                priceForServicePackage = 1000;
            }

            double totalPrice = (priceForHall + priceForServicePackage) - ((priceForHall + priceForServicePackage) * discount);
            double pricePerPerson = totalPrice / numberOfPeople;

            if (priceForHall != 0)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }


        }
    }
}
