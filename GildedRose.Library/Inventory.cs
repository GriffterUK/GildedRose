using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GildedRose.Strategies;

namespace GildedRose
{
    public class Inventory : IEquatable<Inventory>
    {
        private IList<Item> items = new List<Item>();  
        public IList<Item> Items {  get { return items;  } }

        private IItemUpdateStrategyFactory itemUpdateStrategyFactory;

        public Inventory(IItemUpdateStrategyFactory itemUpdateStrategyFactory)
        {
            if (itemUpdateStrategyFactory == null)
            {
                throw new ArgumentNullException("itemUpdateStrategyFactory");
            }

            this.itemUpdateStrategyFactory = itemUpdateStrategyFactory;
        }

        public static Inventory Create(IItemUpdateStrategyFactory itemUpdateStrategyFactory)
        {
            return new Inventory(itemUpdateStrategyFactory);
        }

        public static Inventory CreateDefault(IItemUpdateStrategyFactory itemUpdateStrategyFactory)
        {
            Inventory inventory = new Inventory(itemUpdateStrategyFactory);

            inventory.AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(10).WithQuality(20).Build());
            inventory.AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(2).WithQuality(0).Build());
            inventory.AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(5).WithQuality(7).Build());
            inventory.AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            inventory.AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(15).WithQuality(20).Build());
            inventory.AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(3).WithQuality(6).Build());

            return inventory;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void UpdateQuality()
        {            
            foreach (Item item in Items)
            {
                itemUpdateStrategyFactory.StrategyFor(item.Name).Update(item);
            }
        }

        public void DisplayItems()
        {
            foreach (Item ThisItem in Items)
            {
                System.Console.WriteLine(ThisItem.ToString());
            }
        }

        public void ReconstructMe()
        {
            System.Console.WriteLine("Inventory inventory = new Inventory();");
            System.Console.WriteLine("");

            foreach (Item ThisItem in Items)
            {
                System.Console.WriteLine(String.Format(
                    "inventory.AddItem(ItemBuilder.AnItem().WithName(\"{0}\").WithSellIn({1}).WithQuality({2}).Build());",
                    ThisItem.Name, ThisItem.SellIn, ThisItem.Quality));
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("");

        }

        public Item FindItemByName(string name)
        {
            foreach (Item item in Items)
            {
                if ( item.Name.CompareTo(name) == 0 )
                {
                    return item;
                }
            }

            return null;
        }
        
        public bool Equals(Inventory other)
        {
            if ( this.Items.Count == other.Items.Count )
            {
                bool isEqual = true;
                foreach (Item myItem in Items)
                {
                    Item otherItem = other.FindItemByName(myItem.Name);
                    if ( otherItem == null || otherItem.Quality != myItem.Quality || otherItem.SellIn != myItem.SellIn )
                    {
                        isEqual = false;
                        break;
                    }
                }

                return isEqual;
            }

            return false;
        }
    }
}
