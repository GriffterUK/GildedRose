using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    public interface IItemUpdateStrategyFactory
    {
        IItemUpdateStrategy StrategyFor(string itemName);
    }
}
