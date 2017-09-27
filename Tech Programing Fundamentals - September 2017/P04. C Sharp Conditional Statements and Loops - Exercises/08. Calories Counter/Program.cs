using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());

            int cheeseKcal = 500;
            int tomatoSauceKcal = 150;
            int salamiKcal = 600;
            int pepperKcal = 50;
            int totalKcal = 0;
            for (int i = 0; i < numberOfIngredients; i++)
            {
                string nameOfIngredient = Console.ReadLine();
                nameOfIngredient = nameOfIngredient.ToLower();

                if (nameOfIngredient == "cheese")
                {
                    totalKcal += cheeseKcal;
                }
                else if (nameOfIngredient == "tomato sauce")
                {
                    totalKcal += tomatoSauceKcal;
                }
                else if (nameOfIngredient == "salami")
                {
                    totalKcal += salamiKcal;
                }
                else if (nameOfIngredient == "pepper")
                {
                    totalKcal += pepperKcal;
                }
            }
            Console.WriteLine($"Total calories: {totalKcal}");
        }
    }
}
