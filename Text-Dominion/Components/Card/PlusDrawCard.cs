namespace Text_Dominion.Components.Card
{
    public class PlusDrawCard : CardDecorator
    {
        public byte Cards;
        public PlusDrawCard(byte cards, BaseCard decoratedCard) : base(decoratedCard)
        {
            Cards = cards;
        }
    }
}
