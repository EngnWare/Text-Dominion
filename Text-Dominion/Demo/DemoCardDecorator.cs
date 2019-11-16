﻿using System;
using System.Collections.Generic;
using Text_Dominion.Components.Card;
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
                //PlusMoney = 2
            };
            var silver = new PlusMoneyCard(2, new CostCard(3, new BaseCard()))
            {
                Name = "Silver",
                Type = "Treasure",
                //Cost = 3,
                //PlusMoney = 2
            };
            var gold = new PlusMoneyCard(3, new CostCard(6, new BaseCard()))
            {
                Name = "Gold",
                Type = "Treasure",
                //Cost = 6,
                //PlusMoney = 2
            };
            var cards = new List<CardDecorator> {copper, silver, gold};
            PlayCards(cards);

            var i = TreasuresCards.Copper;
            var i2 = TreasuresCards.Copper;
            var i3 = TreasuresCards.Copper;
            var i4 = TreasuresCards.Silver;
            var i5 = TreasuresCards.Gold;

            i.Name = "Modified the first copper name only";
            cards = new List<CardDecorator> {i, i2, i3, i4, i5};
            PlayCards(cards);
        }

        public static void MarketDemo()
        {
            //Let's play the Market card
            var market = KingdomCards.Market;
            Console.WriteLine(market.Name);
            Console.WriteLine(market.Type);
        }

        private static void PlayCards(IEnumerable<CardDecorator> cards)
        {
            var player = new Player();
            foreach (var card in cards)
            {
                Console.WriteLine(card.Name);
                Console.WriteLine(card.Type);
                /* Console.WriteLine(card.PlusMoney);
                 * Can't view decorated properties at compile time? Hm.
                 * Well, it's not really needed. Just makes me pause with concern.
                 */

                player.Buy(card);
                //player.Play(card);
            }
        }
    }
}
