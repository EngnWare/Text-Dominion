using Text_Dominion.Players;

namespace Text_Dominion.Components.Card.Abstraction
{
    public class BaseCard : ICard
    {
        //every card has...
        public string Name;
        public string Type;

        public void Buy(Player player)
        {
            throw new System.NotImplementedException();
        }

        public void Discard(Player player)
        {
            throw new System.NotImplementedException();
        }

        public void Gain(Player player)
        {
            throw new System.NotImplementedException();
        }

        public string GetCardType()
        {
            throw new System.NotImplementedException();
        }

        public bool IsPlayable(Player player)
        {
            throw new System.NotImplementedException();
        }

        public void Play(Player player)
        {
            throw new System.NotImplementedException();
        }

        public void Reveal(Player player)
        {
            throw new System.NotImplementedException();
        }

        public void Trash(Player player)
        {
            throw new System.NotImplementedException();
        }
    }

    public class CostCard : BaseCard //
    {
        public CostCard()
        {
            //todo
        }
    }

    public class AbstractCard : ICard
    {
        //most have...
        public byte Cost;
        
        //public AbstractCard(string name, byte cost, string type)
        //{
        //    Name = name;
        //    Cost = cost;
        //    Type = type;
        //}

        //public void SetType(string type) //because VictoryCard implements AbstractCard 
        //{
        //    Type = type;
        //}

        public void Buy(Player player)
        {
            player.Buys -= 1;
            player.Treasure -= Cost;
            player.DiscardPile.Add(this); //Or is this in gain?
        }
        public void Gain(Player player)
        {
            player.Treasure -= Cost;
        }

        public void Play(Player player)
        {
            player.CardsInPlay.Add(this);
        }
        public void Discard(Player player)
        {

        }
        public void Reveal(Player player)
        {

        }
        public string GetCardType()
        {
            return Type;
        }

        public void Trash(Player player)
        {

        }

        public bool IsPlayable(Player player)
        {
            return true;
        }
    }

    public class Card : AbstractCard
    {
        //all basic implementations from the abstract class
        public Card(string name, byte cost, string type)
        {
            Name = name;
            Cost = cost;
            Type = type;
        }

    }

    //public class CostCard : AbstractCard
    //{
    //    public byte Cost;
    //}

    //public class PlusTreasureCard : AbstractCard
    //{
    //    public byte PlayValue;
        
    //    public void Play(Player player)
    //    {
    //        player.Treasure += PlayValue;
    //    }
    //}

    //public class ConcreteCard : AbstractCard
    //{
    //    public ConcreteCard(byte cost, string type)
    //    {
    //        Cost = cost;
    //        Type = type; //Make a readonly list;
    //    }
    //}

    //public class DebtCard : AbstractCard
    //{
    //    private byte Debt;

    //    //demonstration of idea
    //    public DebtCard(byte cost, byte playValue, string type, byte debt)
    //    {
    //        Cost = cost;
    //        PlayValue = playValue;
    //        Type = type; //Make a readonly list;
    //        Debt = debt;
    //    }

    //    public new void Buy(Player player)
    //    {
    //        player.Treasure -= Cost;
    //        player.Debt += Debt;
    //    }
    //}
}
