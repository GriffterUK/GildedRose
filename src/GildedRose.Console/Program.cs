using System;
using System.Collections.Generic;

using GildedRose;

namespace GildedRose.Console
{
    class Program
    {
         static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program();

            Inventory InnInventory = Inventory.Create();

            System.Console.WriteLine("\n\nBefore\n");
            InnInventory.DisplayItems();

            for (int iterations = 0; iterations < 20; iterations++)
            {
                System.Console.WriteLine("\n\nAfter (" + iterations + ") iterations\n");
                InnInventory.UpdateQuality();
                InnInventory.DisplayItems();
            }

            System.Console.ReadKey();

        }
    }
}
