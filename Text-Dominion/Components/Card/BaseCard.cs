using System;
using System.Collections.Generic;
using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Players;

namespace Text_Dominion.Components.Card
{

    public class BaseCard : AbstractCard
    {
        public string Name;
        public HashSet<string> Types;
        public byte Cost;
        public byte PlusActions;
        public byte PlusBuys;
        public byte PlusCards;
        public byte PlusTreasure;

        public override void Buy(Player player)
        {
            player.Treasure -= Cost;
            player.DiscardPile.Add(this);
            //Notify card gained messageHub?
        }

        public override void Gain(Player player)
        {
            Console.WriteLine($"Gained {Name}.");
        }

        public override void Play(Player player)
        {
            player.Actions += PlusActions;
            player.Buys += PlusBuys;
            player.Draw(PlusCards);
            player.Treasure += PlusTreasure;
        }

        public override void Discard(Player player)
        {
            //TODO: what's responsible for knowing where the card already is? (deck, hand, play field...)
            player.DiscardPile.Add(this);
        }

        public override void Reveal(Player player)
        {
            Console.WriteLine($"Reveal {Name}");
        }

        //public string GetCardType()
        //{
        //    return this.Type;
        //}

        //public bool IsPlayable(Player player)
        //{
        //    return true;
        //}


        //public void Trash(Player player)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
