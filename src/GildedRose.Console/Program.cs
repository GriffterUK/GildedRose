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

            Inventory InnInventory = Inventory.CreateDefault();

            System.Console.WriteLine("\n\nBefore\n");
            InnInventory.ReconstructMe();

            for (int iterations = 0; iterations < 10; iterations++)
            {
                System.Console.WriteLine("\n\nAfter (" + (iterations + 1) + ") iterations\n");
                InnInventory.UpdateQuality();       
                InnInventory.ReconstructMe();
            }

            System.Console.ReadKey();

        }
    }
}
