using System;
using Text_Dominion.Players;

namespace Text_Dominion.Components.Card.Abstraction
{
    public abstract class AbstractCard
    {
        public string Name;
        public string Type;

        public abstract void Buy(Player player);
        //public abstract void Gain(Player player);
        //public abstract void Play(Player player);
        //public abstract void Discard(Player player);
        //public abstract void Reveal(Player player);
        //public abstract string GetCardType();
        //public abstract void Trash(Player player);
        //public abstract bool IsPlayable(Player player);
    }

    public class BaseCard : AbstractCard
    {
        //every card has...
        //public string Name;
        //public list<type> Types;
        //...but not sure anything else is guaranteed but...
        /*
         * I am strongly considering setting buys, actions, cost, plusMoney, etc.
         * as properties in the base class.
         * ...Man, Decorator syntax is such a mess.
         */
        
        public override void Buy(Player player)
        {
            //Add one to GainCount
            //player.DiscardPile.Add(this);

        }
        //public override void Gain(Player player)
        //{
        //    //Add one to GainCount
        //    player.DiscardPile.Add(this);
        //}

        //public override void Play(Player player)
        //{
        //    player.PlayPile.Add(this);
        //}
        //public void Discard(Player player)
        //{
        //    //TODO: what's responsible for knowing where the card already is? (deck, hand, play field...)
        //    //Maybe make a Player.ActiveCard s.t. the card in question is just added to DiscardPile
        //    player.DiscardPile.Remove(this);
        //    player.DiscardPile.Add(this);
        //}

        //public string GetCardType()
        //{
        //    return this.Type;
        //}

        //public bool IsPlayable(Player player)
        //{
        //    return true;
        //}

        //public void Reveal(Player player)
        //{
        //    //TODO: display details?
        //}

        //public void Trash(Player player)
        //{
        //    throw new System.NotImplementedException();
        //}
    }

    public class CardDecorator : BaseCard
    {
        protected BaseCard DecoratedCard;

        public CardDecorator(BaseCard decoratedCard)
        {
            DecoratedCard = decoratedCard;
        }

        public override void Buy(Player player)
        {
            DecoratedCard.Buy(player);
        }

        //public new void Gain(Player player)
        //{
        //    DecoratedCard.Gain(player);
        //}

        //public new void Play(Player player)
        //{
        //    DecoratedCard.Play(player);
        //}
        //public new void Discard(Player player)
        //{
        //    DecoratedCard.Discard(player);
        //}

        //public new string GetCardType()
        //{
        //    return DecoratedCard.GetCardType();
        //}

        //public new bool IsPlayable(Player player)
        //{
        //    return DecoratedCard.IsPlayable(player);
        //}

        //public new void Reveal(Player player)
        //{
        //    DecoratedCard.Reveal(player);
        //}

        //public new void Trash(Player player)
        //{
        //    DecoratedCard.Trash(player);
        //}
    }

    public class CostCard : CardDecorator
    {
        public byte Cost;

        public CostCard(byte cost, BaseCard card) : base(card)
        {
            Cost = cost;
        }

        //public override void Buy()
        //{
        //    DecoratedCard.Buy() + Cost;
        //}
    }


    public class PlusMoneyCard : CardDecorator
    {
        public byte PlusMoney;

        public PlusMoneyCard(byte plusMoney, BaseCard card) : base(card)
        {
            PlusMoney = plusMoney;
        }

        //public override bool Play()
        //{
        //    Console.WriteLine($"Add {PlusMoney} treasures to player.");
        //    return DecoratedCard.Play();
        //}
    }
}
