﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = ((2 * 15) + 100) / 2;
            var res = "Tek";
            if (x % 2 == 0)
                res = "Cut";

            Console.Write($"{"Netice: "}{res}{Environment.NewLine}{x}");
            Console.ReadKey();
        }
    }
}
