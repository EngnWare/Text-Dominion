namespace Text_Dominion.Components.Card
{
    public class PlusActionCard : CardDecorator
    {
        public byte Actions;
        public PlusActionCard(byte actions, BaseCard decoratedCard) : base(decoratedCard)
        {
            Actions = actions;
        }
    }
}
