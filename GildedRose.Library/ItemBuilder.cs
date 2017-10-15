using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class ItemBuilder
    {
        private Item item = new Item();

        public static ItemBuilder AnItem()
        {
            return new ItemBuilder();
        }

        public ItemBuilder WithName(string name)
        {
            item.Name = name;
            return this;
        }

        public ItemBuilder WithSellIn(int sellIn)
        {
            item.SellIn = sellIn;
            return this;
        }

        public ItemBuilder WithQuality(int quality)
        {
            item.Quality = quality;
            return this;
        }

        public Item Build()
        {
            return item;
        }
    }
}
