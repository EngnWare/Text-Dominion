using System;
using System.Collections.Generic;
using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Database.BaseSet;
using Text_Dominion.Players;

namespace Text_Dominion.Demo
{
    public static class DemoCarDecorator
    {
        public static void Run()
        {
            var copper = new PlusMoneyCard(1, new CostCard(0, new BaseCard()))
            {
                Name = "Copper",
                Type = "Treasure",
                //Cost = 0,
                //PlusTreasure = 2
            };
            var silver = new PlusMoneyCard(2, new CostCard(3, new BaseCard()))
            {
                Name = "Silver",
                Type = "Treasure",
                //Cost = 3,
                //PlusTreasure = 2
            };
            var gold = new PlusMoneyCard(3, new CostCard(6, new BaseCard()))
            {
                Name = "Gold",
                Type = "Treasure",
                //Cost = 6,
                //PlusTreasure = 2
            };
            var cards = new List<CardDecorator> {copper, silver, gold};
            PlayCards(cards);

            var i = Treasures.Copper;
            var i2 = Treasures.Copper;
            var i3 = Treasures.Copper;
            var i4 = Treasures.Silver;
            var i5 = Treasures.Gold;

            i.Name = "Modified the first copper name only";
            cards = new List<CardDecorator> {i, i2, i3, i4, i5};
            PlayCards(cards);
        }

        private static void PlayCards(IEnumerable<CardDecorator> cards)
        {
            var player = new Player();
            foreach (var card in cards)
            {
                Console.WriteLine(card.Name);
                Console.WriteLine(card.Type);
                /* Console.WriteLine(card.PlusTreasure);
                 * Can't view decorated properties at compile time? Hm.
                 * Well, it's not really needed. Just makes me pause with concern.
                 */

                player.Buy(card);
                //player.Play(card);
            }
        }
    }
}
