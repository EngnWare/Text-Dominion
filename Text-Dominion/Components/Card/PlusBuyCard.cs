namespace Text_Dominion.Components.Card
{
    public class PlusBuyCard : CardDecorator
    {
        public byte Buys;
        public PlusBuyCard(byte buys, BaseCard decoratedCard) : base(decoratedCard)
        {
            Buys = buys;
        }
    }
}
