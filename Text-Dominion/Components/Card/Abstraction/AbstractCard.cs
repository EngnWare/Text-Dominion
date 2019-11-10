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
        //public string Type;
        //...but not sure anything else is gauranteed
        
        public override void Buy(Player player)
        {
            //Add one to GainCount
            player.DiscardPile.Add(this);

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

    public class CardDecorator : AbstractCard
    {
        protected AbstractCard DecoratedCard;

        public CardDecorator(AbstractCard decoratedCard)
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

        public CostCard(AbstractCard card)
        {
            DecoratedCard = card;
        }
    }
}
