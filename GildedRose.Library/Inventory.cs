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
