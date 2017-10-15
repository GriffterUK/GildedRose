using System.Collections.Generic;
using Xunit;

using GildedRose;
using GildedRose.Strategies;

namespace GildedRose.Tests
{
    public class GildedRoseShould
    {
        protected IList<Inventory> goldenMasterInventories = new List<Inventory>();

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

            InitialiseGoldenMaster();
        }

        public Inventory CreateInitialInventory()
        {            
            Inventory inventory = new Inventory(ItemUpdateStrategyFactory.Instance);

            inventory.AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(10).WithQuality(20).Build());
            inventory.AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(2).WithQuality(0).Build());
            inventory.AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(5).WithQuality(7).Build());
            inventory.AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            inventory.AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(15).WithQuality(20).Build());
            inventory.AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(3).WithQuality(6).Build());

            return inventory;   
        }

        public void InitialiseGoldenMaster()
        { 
            goldenMasterInventories.Add(CreateInitialInventory());
            for (int iterations = 0; iterations < 10; iterations++) {
                goldenMasterInventories.Add(Inventory.Create(ItemUpdateStrategyFactory.Instance));
            }

            goldenMasterInventories[1].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(9).WithQuality(19).Build());
            goldenMasterInventories[1].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(1).WithQuality(1).Build());
            goldenMasterInventories[1].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(4).WithQuality(6).Build());
            goldenMasterInventories[1].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            goldenMasterInventories[1].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(14).WithQuality(21).Build());
            goldenMasterInventories[1].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(2).WithQuality(4).Build());

            goldenMasterInventories[2].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(8).WithQuality(18).Build());
            goldenMasterInventories[2].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(0).WithQuality(2).Build());
            goldenMasterInventories[2].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(3).WithQuality(5).Build());
            goldenMasterInventories[2].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            goldenMasterInventories[2].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(13).WithQuality(22).Build());
            goldenMasterInventories[2].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(1).WithQuality(2).Build());

            goldenMasterInventories[3].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(7).WithQuality(17).Build());
            goldenMasterInventories[3].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-1).WithQuality(4).Build());
            goldenMasterInventories[3].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(2).WithQuality(4).Build());
            goldenMasterInventories[3].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            goldenMasterInventories[3].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(12).WithQuality(23).Build());
            goldenMasterInventories[3].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(0).WithQuality(0).Build());

            goldenMasterInventories[4].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(6).WithQuality(16).Build());
            goldenMasterInventories[4].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-2).WithQuality(6).Build());
            goldenMasterInventories[4].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(1).WithQuality(3).Build());
            goldenMasterInventories[4].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            goldenMasterInventories[4].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(11).WithQuality(24).Build());
            goldenMasterInventories[4].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-1).WithQuality(0).Build());

            goldenMasterInventories[5].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(5).WithQuality(15).Build());
            goldenMasterInventories[5].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-3).WithQuality(8).Build());
            goldenMasterInventories[5].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(0).WithQuality(2).Build());
            goldenMasterInventories[5].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            goldenMasterInventories[5].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(10).WithQuality(25).Build());
            goldenMasterInventories[5].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-2).WithQuality(0).Build());

            goldenMasterInventories[6].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(4).WithQuality(14).Build());
            goldenMasterInventories[6].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-4).WithQuality(10).Build());
            goldenMasterInventories[6].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(-1).WithQuality(0).Build());
            goldenMasterInventories[6].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            goldenMasterInventories[6].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(9).WithQuality(27).Build());
            goldenMasterInventories[6].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-3).WithQuality(0).Build());

            goldenMasterInventories[7].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(3).WithQuality(13).Build());
            goldenMasterInventories[7].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-5).WithQuality(12).Build());
            goldenMasterInventories[7].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(-2).WithQuality(0).Build());
            goldenMasterInventories[7].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            goldenMasterInventories[7].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(8).WithQuality(29).Build());
            goldenMasterInventories[7].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-4).WithQuality(0).Build());

            goldenMasterInventories[8].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(2).WithQuality(12).Build());
            goldenMasterInventories[8].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-6).WithQuality(14).Build());
            goldenMasterInventories[8].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(-3).WithQuality(0).Build());
            goldenMasterInventories[8].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            goldenMasterInventories[8].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(7).WithQuality(31).Build());
            goldenMasterInventories[8].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-5).WithQuality(0).Build());

            goldenMasterInventories[9].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(1).WithQuality(11).Build());
            goldenMasterInventories[9].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-7).WithQuality(16).Build());
            goldenMasterInventories[9].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(-4).WithQuality(0).Build());
            goldenMasterInventories[9].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            goldenMasterInventories[9].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(6).WithQuality(33).Build());
            goldenMasterInventories[9].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-6).WithQuality(0).Build());

            goldenMasterInventories[10].AddItem(ItemBuilder.AnItem().WithName("+5 Dexterity Vest").WithSellIn(0).WithQuality(10).Build());
            goldenMasterInventories[10].AddItem(ItemBuilder.AnItem().WithName("Aged Brie").WithSellIn(-8).WithQuality(18).Build());
            goldenMasterInventories[10].AddItem(ItemBuilder.AnItem().WithName("Elixir of the Mongoose").WithSellIn(-5).WithQuality(0).Build());
            goldenMasterInventories[10].AddItem(ItemBuilder.AnItem().WithName("Sulfuras, Hand of Ragnaros").WithSellIn(0).WithQuality(80).Build());
            goldenMasterInventories[10].AddItem(ItemBuilder.AnItem().WithName("Backstage passes to a TAFKAL80ETC concert").WithSellIn(5).WithQuality(35).Build());
            goldenMasterInventories[10].AddItem(ItemBuilder.AnItem().WithName("Conjured Mana Cake").WithSellIn(-7).WithQuality(0).Build());
        }   


        [Fact]
        public void MatchGoldenMasterAfterRefactor()
        {
            Inventory innInventory = CreateInitialInventory();
            foreach (Inventory thisInventory in goldenMasterInventories)
            {
                Assert.True(innInventory.Equals(thisInventory));
                innInventory.UpdateQuality();
            } 
        }

        [Fact]
        public void ExpectConjuredItemsToDegradeTwiceAsFastAsNormalItems()
        {
            string itemName = "Conjured Mana Cake";
            Inventory inventory = Inventory.Create(ItemUpdateStrategyFactory.Instance);

            inventory.AddItem(ItemBuilder.AnItem().WithName(itemName).WithSellIn(3).WithQuality(12).Build());

            inventory.UpdateQuality();
            Assert.Equal(10, inventory.FindItemByName(itemName).Quality);

            inventory.UpdateQuality();
            Assert.Equal(8, inventory.FindItemByName(itemName).Quality);

            inventory.UpdateQuality();
            Assert.Equal(6, inventory.FindItemByName(itemName).Quality);

            inventory.UpdateQuality(); // should expire now so degrade even quicker again
            Assert.Equal(2, inventory.FindItemByName(itemName).Quality);

            inventory.UpdateQuality();
            Assert.Equal(0, inventory.FindItemByName(itemName).Quality);
        }

    }
}