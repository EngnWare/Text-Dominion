using Text_Dominion.Players;

namespace Text_Dominion.Components.Card.Abstraction
{
    public class CardDecorator : ICard
    {
        //every card has...
        public string Name;
        public string Type;

        protected ICard DecoratedCard;

        public CardDecorator(ICard decoratedCard)
        {
            DecoratedCard = decoratedCard;
        }

        public void Buy(Player player)
        {
            DecoratedCard.Buy(player);
        }
        public void Gain(Player player)
        {
            DecoratedCard.Gain(player);
        }

        public void Play(Player player)
        {
            DecoratedCard.Play(player);
        }
        public void Discard(Player player)
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

        public void Reveal(Player player)
        {
            throw new System.NotImplementedException();
        }

        public void Trash(Player player)
        {
            throw new System.NotImplementedException();
        }
    }

    public class CostCard : CardDecorator
    {
        public byte Cost;
        public CostCard(ICard decoratedCard)
        {
            //todo
        }
    }
}
