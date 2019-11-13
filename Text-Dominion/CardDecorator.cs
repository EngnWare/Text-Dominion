using System;
using System.Collections.Generic;

namespace CrypDominion
{
    public interface ICard
    {
        byte GetCost(IEnumerable<string> items);
    }

    public abstract class CardBase
    {
        public string Name;
        public byte Cost;

        public abstract double Buy();
        public abstract bool Play();
    }

    public class PlainCard : CardBase
    {
        public override double Buy()
        {
            //basic things like ...
            return 0;
        }

        public override bool Play()
        {
            //basic things like remove from hand add to play area
            return true;
        }
    }

    public class CardDecorator : CardBase
    {
        protected CardBase DecoratedCard;

        public CardDecorator(CardBase decoratedCard)
        {
            this.DecoratedCard = decoratedCard;
        }

        public override double Buy()
        {
            return DecoratedCard.Buy();
        }

        public override bool Play()
        {
            return DecoratedCard.Play();
        }
    }

    public class CostCard : CardDecorator
    {
        public CostCard(byte cost, CardBase card) : base(card)
        {
            Cost = cost;
        }

        public override double Buy()
        {
            return DecoratedCard.Buy() + Cost;
        }
    }


    public class PlusMoneyCard : CardDecorator
    {
        public byte PlusMoney;

        public PlusMoneyCard(byte plusMoney, CardBase card) : base(card)
        {
            PlusMoney = plusMoney;
        }

        public override bool Play()
        {
            Console.WriteLine($"Add {PlusMoney} treasures to player.");
            return DecoratedCard.Play();
        }
    }
}
