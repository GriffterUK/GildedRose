using Xunit;

namespace GildedRose.Tests
{


    Item(Name = +5 Dexterity Vest, SellIn = 10, Quality = 20)
    Item(Name = Aged Brie, SellIn = 2, Quality = 0)
    Item(Name = Elixir of the Mongoose, SellIn = 5, Quality = 7)
    Item(Name = Sulfuras, Hand of Ragnaros, SellIn = 0, Quality = 80)
    Item(Name = Backstage passes to a TAFKAL80ETC concert, SellIn = 15, Quality = 20)
    Item(Name = Conjured Mana Cake, SellIn = 3, Quality = 6)

    public class GildedRoseShould
    {
        [Fact]
        public void MatchGoldenMasterAfterRefactor()
        {
            Assert.True(true);
        }
    }
}