using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    class ItemModifier
    { 
        private Item item;

        public ItemModifier(Item thisItem)
        {
            this.item = thisItem;
        }

        public static ItemModifier Modify(Item thisItem)
        {
            return new ItemModifier(thisItem);
        }

        public ItemModifier IncreaseAge()
        {
            this.item.SellIn--;
            return this;
        }

        public ItemModifier IncreaseQuality()
        {
            this.item.Quality++;
            return this;
        }

        public ItemModifier DecreaseQuality()
        {
            this.item.Quality--;
            return this;
        }

        public ItemModifier IncreaseQualityWhenExpiryInLessThan(int sellInLessThan)
        {
            this.item.Quality+=this.item.SellIn < sellInLessThan ? 1 : 0 ;
            return this;
        }

        public ItemModifier DecreaseQualityWhenExpired()
        {
            this.item.Quality -= this.item.SellIn < 0 ? 1 : 0;
            return this;
        }

        public ItemModifier ReduceAllQualityWhenExpired()
        {
            this.item.Quality = this.item.SellIn < 0 ? 0 : this.item.Quality;
            return this;
        }

        public ItemModifier IncreaseQualityWhenExpired()
        {
            this.item.Quality += this.item.SellIn < 0 ? 1 : 0;
            return this;
        }

        public ItemModifier LimitQualityToNoMoreThan(int qualityLimit)
        {
            this.item.Quality = Math.Min(qualityLimit, this.item.Quality);
            return this;
        }

        public ItemModifier LimitQualityToNoLessThan(int qualityLimit)
        {
            this.item.Quality = Math.Max(qualityLimit, this.item.Quality);
            return this;
        }

       
    }
}
