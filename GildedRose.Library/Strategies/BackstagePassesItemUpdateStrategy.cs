using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    class BackstagePassesItemUpdateStrategy : IItemUpdateStrategy
    {
        private BackstagePassesItemUpdateStrategy() { }

        public static IItemUpdateStrategy Create()
        {
            return new BackstagePassesItemUpdateStrategy();
        }

        public void Update(Item item)
        {
            ItemModifier.Modify(item)
                .IncreaseAge()
                .IncreaseQuality()
                .IncreaseQualityWhenExpiryInLessThan(10)
                .IncreaseQualityWhenExpiryInLessThan(5)
                .ReduceAllQualityWhenExpired()
                .LimitQualityToNoMoreThan(50);
        }
    }
}
