using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamaged = int.Parse(Console.ReadLine());
            int goshoDamaged = int.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho = 100;

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    healthPesho -= goshoDamaged;
                    if (healthPesho <= 0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                        break;
                    }
                    else
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                }
                else
                {
                    healthGosho -= peshoDamaged;
                    if (healthGosho <= 0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        break;
                    }
                    else
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                }

                if (i % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
            }
        }
    }
}
