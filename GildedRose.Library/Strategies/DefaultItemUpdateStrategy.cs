using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    class DefaultItemUpdateStrategy : IItemUpdateStrategy
    {
        private DefaultItemUpdateStrategy() { }

        public static IItemUpdateStrategy Create()
        {
            return new DefaultItemUpdateStrategy();
        }

        public void Update(Item item)
        {
            ItemModifier.Modify(item)
                .IncreaseAge()
                .DecreaseQuality()
                .DecreaseQualityWhenExpired()
                .LimitQualityToNoLessThan(0);
        }
    }
}
