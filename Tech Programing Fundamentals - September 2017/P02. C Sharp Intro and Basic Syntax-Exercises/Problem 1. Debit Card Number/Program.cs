﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourNumber = int.Parse(Console.ReadLine());

            Console.Write($"{firstNumber:D4} ");
            Console.Write($"{secondNumber:D4} ");
            Console.Write($"{thirdNumber:D4} ");
            Console.Write($"{fourNumber:D4} ");
        }
    }
}
