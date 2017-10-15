using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class Inventory : IEquatable<Inventory>
    {
        private IList<Item> items = new List<Item>();  
        public IList<Item> Items {  get { return items;  } }
            
        public static Inventory Create()
        {
            return new Inventory();
        }

        public static Inventory CreateDefault()
        {
            Inventory inventory = new Inventory();

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
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
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
