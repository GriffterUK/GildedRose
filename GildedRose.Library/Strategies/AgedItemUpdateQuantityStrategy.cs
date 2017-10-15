using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    public class AgedItemUpdateStrategy : IItemUpdateStrategy
    {
        private AgedItemUpdateStrategy() { }

        public static IItemUpdateStrategy Create()
        {
            return new AgedItemUpdateStrategy();
        }

        public void Update(Item item)
        {
            ItemModifier.Modify(item)
              .IncreaseAge()
              .IncreaseQuality()
              .IncreaseQualityWhenExpired()
              .LimitQualityToNoMoreThan(50);
        }
    }
}
