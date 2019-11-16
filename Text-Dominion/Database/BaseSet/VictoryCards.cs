using Text_Dominion.Components.Card;

namespace Text_Dominion.Database.BaseSet
{
    public class VictoryCards
    {
        public static CardDecorator Estate => new VictoryCard(1, new CostCard(2, new BaseCard()))
        {
            Name = "Estate",
            Type = "Victory",
            //Cost = 1,
            //PlusVictory = 1
        };
        public static CardDecorator Duchy => new VictoryCard(3, new CostCard(5, new BaseCard()))
        {
            Name = "Duchy",
            Type = "Victory",
            //Cost = 5,
            //PlusVictory = 3
        };
        public static CardDecorator Province => new VictoryCard(6, new CostCard(8, new BaseCard()))
        {
            Name = "Province",
            Type = "Victory",
            //Cost = 8,
            //PlusVictory = 6
        };
    }
}
