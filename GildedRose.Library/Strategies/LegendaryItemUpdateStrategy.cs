using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    public class LegendaryItemUpdateStrategy : IItemUpdateStrategy
    {
        private LegendaryItemUpdateStrategy() { }

        public static IItemUpdateStrategy Create()
        {
            return new LegendaryItemUpdateStrategy();
        }

        public void Update(Item item)
        {
            // Legendary items do not age, or lose quality
            // .....so let's do nothing!
        }
    }
}
