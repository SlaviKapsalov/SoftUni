﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int product = 1;
            for (int i = 1; i <= 10; i++)
            {
                product = n * i;
                Console.WriteLine($"{n} X {i} = {product}");
            }
        }
    }
}
