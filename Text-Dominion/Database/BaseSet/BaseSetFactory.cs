using Text_Dominion.Components.Card;
using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Database.BaseSet.Cards;

namespace Text_Dominion.Database.BaseSet
{
    public class BaseSetFactory
    {
        public static AbstractCard Market => new BaseCard
        {
            Cost = 5,
            PlusActions = 1,
            PlusBuys = 1,
            PlusCards = 1,
            PlusTreasure = 1
        };

        public static AbstractCard Village => new BaseCard
        {
            Cost = 3,
            PlusActions = 2,
            PlusCards = 1,
        };

        public static AbstractCard Smithy => new BaseCard
        {
            Cost = 4,
            PlusCards = 3
        };

        public static AbstractCard Laboratory => new BaseCard
        {
            Cost = 5,
            PlusCards = 2,
            PlusActions = 1
        };

        public static AbstractCard Festival => new BaseCard
        {
            Cost = 5,
            PlusActions = 2,
            PlusBuys = 1,
            PlusTreasure = 2
        };
    }
}
