using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = 0;
            for (int i = 0; i <= 20; i++)
            {
                string nameOfIngredient = Console.ReadLine();
                if (nameOfIngredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
                    break;
                }
                else
                {
                    numberOfIngredients++;
                    Console.WriteLine($"Adding ingredient {nameOfIngredient}.");
                }
            }
        }
    }
}
