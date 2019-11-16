namespace Text_Dominion.Components.Card
{
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
}
