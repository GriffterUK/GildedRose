using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    class ItemUpdateQuantityStrategyFactory
    {
        public IItemUpdateQuantityStrategy StrategyFor(string itemName)
        {
            if (itemName.Contains("Aged"))
            {
                return AgedItemUpdateStrategy.Create();
            }
            else if (itemName.Contains("Sulfuras")) 
            {
                return LegendaryItemUpdateStrategy.Create();
            }
            else
            {
                return DefaultItemUpdateStrategy.Create();
            }
        }
    }


    //All items have a SellIn value which denotes the number of days we have to sell the item
    //All items have a Quality value which denotes how valuable the item is
    //At the end of each day our system lowers both values for every item
    //Pretty simple, right? Well this is where it gets interesting:

    //Once the sell by date has passed, Quality degrades twice as fast
    //The Quality of an item is never negative

    //"Aged Brie" actually increases in Quality the older it gets
    //The Quality of an item is never more than 50
    //"Sulfuras", being a legendary item, never has to be sold or decreases in Quality
    //"Backstage passes", like aged brie, increases in Quality as it's SellIn value approaches; 
    //     Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less 
    //     but Quality drops to 0 after the concert

    class AgedItemUpdateStrategy : IItemUpdateQuantityStrategy
    {
        private AgedItemUpdateStrategy() { }

        public static IItemUpdateQuantityStrategy Create()
        {
            return new AgedItemUpdateStrategy();
        }

        public void UpdateQuantity(Item item)
        {
            item.SellIn--;
            item.Quality = item.Quality == 50 ? 50 :
                           item.Quality + (item.SellIn < 0 ? 2 : 1);
        }
    }

    class LegendaryItemUpdateStrategy : IItemUpdateQuantityStrategy
    {
        private LegendaryItemUpdateStrategy() { }

        public static IItemUpdateQuantityStrategy Create()
        {
            return new LegendaryItemUpdateStrategy();
        }

        public void UpdateQuantity(Item item)
        {
 
        }
    }

    class DefaultItemUpdateStrategy : IItemUpdateQuantityStrategy
    {
        private DefaultItemUpdateStrategy() { }

        public static IItemUpdateQuantityStrategy Create()
        {
            return new DefaultItemUpdateStrategy();
        }

        public void UpdateQuantity(Item item)
        {
            if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.Quality > 0)
                {
                    if (item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }
                    }
                }
            }

            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != "Sulfuras, Hand of Ragnaros")
                            {
                                item.Quality = item.Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }                      
        }
    }
}
