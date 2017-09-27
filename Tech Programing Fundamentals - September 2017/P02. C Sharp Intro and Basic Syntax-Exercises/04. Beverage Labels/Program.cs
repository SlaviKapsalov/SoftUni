using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
             string name = Console.ReadLine();
             int volume = int.Parse(Console.ReadLine());
             int energyContent = int.Parse(Console.ReadLine());
             int sugarContent = int.Parse(Console.ReadLine());

            double kcal = (volume / 100.0) * energyContent;
            double gSugar = (volume / 100.0) * sugarContent;


            Console.WriteLine($"{volume}ml {name}:");
             Console.WriteLine($"{kcal}kcal, {gSugar}g sugars");

            

        }
    }
}
