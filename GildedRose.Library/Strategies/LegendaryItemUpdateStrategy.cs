using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    class LegendaryItemUpdateStrategy : IItemUpdateStrategy
    {
        private LegendaryItemUpdateStrategy() { }

        public static IItemUpdateStrategy Create()
        {
            return new LegendaryItemUpdateStrategy();
        }

        public void Update(Item item)
        {

        }
    }
}
