﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            Beverage beverage2 = new Espresso();
            Beverage beverage2 = new HouseBlend();
            Console.WriteLine(beverage2.GetDescription() + " " + beverage2.Cost());
            Beverage beverage3 = new Espresso();
            beverage2 = new Mocka(beverage2);

            Console.WriteLine(beverage2.GetDescription() + " " + beverage2.Cost()); 
        }
    }
}
