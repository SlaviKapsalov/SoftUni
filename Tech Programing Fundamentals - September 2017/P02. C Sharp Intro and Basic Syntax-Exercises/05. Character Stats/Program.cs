using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int lostHealth = maxHealth - currentHealth;
            int lostEnergy = maxEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");

            Console.Write("Health: |");
            Console.Write(new string('|', currentHealth));
            Console.Write(new string('.', lostHealth));
            Console.WriteLine("|");

            Console.Write("Energy: |");
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', lostEnergy));
            Console.WriteLine("|");

            

        }
    }
}
