using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{  
    public class ItemUpdateStrategyFactory : IItemUpdateStrategyFactory
    {
        private static ItemUpdateStrategyFactory instance;
        private IDictionary<string, IItemUpdateStrategy> strategies = new Dictionary<string, IItemUpdateStrategy>();

        private ItemUpdateStrategyFactory() {  }

        public static ItemUpdateStrategyFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ItemUpdateStrategyFactory();
                }

                return instance;
            }
        }

        public void RegisterStrategyForItemName(IItemUpdateStrategy strategy, string itemName)
        {
            strategies[itemName] = strategy;
        }

        public IItemUpdateStrategy StrategyFor(string itemName)
        {
            foreach (KeyValuePair<string, IItemUpdateStrategy> strategy in strategies)
            {
                if ( itemName.Contains(strategy.Key))
                {
                    return strategy.Value;
                }               
            }

            return DefaultItemUpdateStrategy.Create();
        }
    }  
}
