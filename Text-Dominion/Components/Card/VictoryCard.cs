namespace Text_Dominion.Components.Card
{
    public class VictoryCard : CardDecorator
    {
        public byte VictoryPoints;
        public VictoryCard(byte victoryPoints, BaseCard card) : base(card)
        {
            VictoryPoints = victoryPoints;
        }
    }
}
