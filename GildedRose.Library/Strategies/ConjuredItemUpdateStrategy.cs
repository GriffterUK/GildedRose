﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    public class ConjuredItemUpdateStrategy : IItemUpdateStrategy
    {
        private ConjuredItemUpdateStrategy() { }

        public static IItemUpdateStrategy Create()
        {
            return new ConjuredItemUpdateStrategy();
        }

        public void Update(Item item)
        {
            ItemModifier.Modify(item)
                .IncreaseAge()
                .DecreaseQuality()
                .DecreaseQuality()
                .DecreaseQualityWhenExpired()
                .DecreaseQualityWhenExpired()
                .LimitQualityToNoLessThan(0);
        }
    }
}
