﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson beedle = new SalesPerson();
            beedle.Age = 28;
            beedle.Name = "Beedle";
            beedle.SalesNumber = 38;

            Console.ReadLine();
        }
    }
}
