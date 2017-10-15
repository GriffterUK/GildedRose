using System.Collections.Generic;
using Xunit;

using GildedRose;
using GildedRose.Strategies;

namespace GildedRose.Tests
{
    public class GildedRoseShould
    {
        protected IList<Inventory> iterativeInventories = new List<Inventory>();

        public GildedRoseShould()
        { 
            ItemUpdateStrategyFactory.Instance.RegisterStrategyForItemName(AgedItemUpdateStrategy.Create(), 
                "Aged");

            ItemUpdateStrategyFactory.Instance.RegisterStrategyForItemName(BackstagePassesItemUpdateStrategy.Create(), 
                "Backstage passes");

            ItemUpdateStrategyFactory.Instance.RegisterStrategyForItemName(LegendaryItemUpdateStrategy.Create(), 
                "Sulfuras");

            ItemUpdateStrategyFactory.Instance.RegisterStrategyForItemName(ConjuredItemUpdateStrategy.Create(),
                "Conjured");


            iterativeInventories.Add(Inventory.CreateDefault(ItemUpdateStrategyFactory.Instance));
            for (int iterations = 0; iterations < 10; iterations++) {
                iterativeInventories.Add(Inventory.Create(ItemUpdateStrategyFactory.Instance));
            }

            iterativeInventories[1].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(9).WithQuality(19).Build());
            iterativeInventories[1].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(1).WithQuality(1).Build());
            iterativeInventories[1].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(4).WithQuality(6).Build());
            iterativeInventories[1].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            iterativeInventories[1].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(14).WithQuality(21).Build());
            iterativeInventories[1].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(2).WithQuality(4).Build());

            iterativeInventories[2].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(8).WithQuality(18).Build());
            iterativeInventories[2].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(0).WithQuality(2).Build());
            iterativeInventories[2].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(3).WithQuality(5).Build());
            iterativeInventories[2].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            iterativeInventories[2].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(13).WithQuality(22).Build());
            iterativeInventories[2].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(1).WithQuality(2).Build());

            iterativeInventories[3].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(7).WithQuality(17).Build());
            iterativeInventories[3].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-1).WithQuality(4).Build());
            iterativeInventories[3].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(2).WithQuality(4).Build());
            iterativeInventories[3].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            iterativeInventories[3].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(12).WithQuality(23).Build());
            iterativeInventories[3].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(0).WithQuality(0).Build());

            iterativeInventories[4].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(6).WithQuality(16).Build());
            iterativeInventories[4].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-2).WithQuality(6).Build());
            iterativeInventories[4].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(1).WithQuality(3).Build());
            iterativeInventories[4].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            iterativeInventories[4].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(11).WithQuality(24).Build());
            iterativeInventories[4].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-1).WithQuality(0).Build());

            iterativeInventories[5].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(5).WithQuality(15).Build());
            iterativeInventories[5].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-3).WithQuality(8).Build());
            iterativeInventories[5].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(0).WithQuality(2).Build());
            iterativeInventories[5].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            iterativeInventories[5].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(10).WithQuality(25).Build());
            iterativeInventories[5].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-2).WithQuality(0).Build());

            iterativeInventories[6].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(4).WithQuality(14).Build());
            iterativeInventories[6].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-4).WithQuality(10).Build());
            iterativeInventories[6].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(-1).WithQuality(0).Build());
            iterativeInventories[6].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            iterativeInventories[6].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(9).WithQuality(27).Build());
            iterativeInventories[6].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-3).WithQuality(0).Build());

            iterativeInventories[7].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(3).WithQuality(13).Build());
            iterativeInventories[7].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-5).WithQuality(12).Build());
            iterativeInventories[7].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(-2).WithQuality(0).Build());
            iterativeInventories[7].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            iterativeInventories[7].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(8).WithQuality(29).Build());
            iterativeInventories[7].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-4).WithQuality(0).Build());

            iterativeInventories[8].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(2).WithQuality(12).Build());
            iterativeInventories[8].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-6).WithQuality(14).Build());
            iterativeInventories[8].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(-3).WithQuality(0).Build());
            iterativeInventories[8].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            iterativeInventories[8].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(7).WithQuality(31).Build());
            iterativeInventories[8].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-5).WithQuality(0).Build());

            iterativeInventories[9].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(1).WithQuality(11).Build());
            iterativeInventories[9].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-7).WithQuality(16).Build());
            iterativeInventories[9].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(-4).WithQuality(0).Build());
            iterativeInventories[9].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            iterativeInventories[9].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(6).WithQuality(33).Build());
            iterativeInventories[9].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-6).WithQuality(0).Build());

            iterativeInventories[10].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(0).WithQuality(10).Build());
            iterativeInventories[10].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-8).WithQuality(18).Build());
            iterativeInventories[10].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(-5).WithQuality(0).Build());
            iterativeInventories[10].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            iterativeInventories[10].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(5).WithQuality(35).Build());
            iterativeInventories[10].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-7).WithQuality(0).Build());
        }   


        [Fact]
        public void MatchGoldenMasterAfterRefactor()
        {
            Inventory innInventory = Inventory.CreateDefault(ItemUpdateStrategyFactory.Instance);
            foreach(Inventory thisInventory in iterativeInventories)
            {
                Assert.True(innInventory.Equals(thisInventory));
                innInventory.UpdateQuality();
            } 
        }
    }
}