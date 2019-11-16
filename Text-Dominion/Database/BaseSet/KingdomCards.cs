using Text_Dominion.Components.Card;

namespace Text_Dominion.Database.BaseSet
{
    public class KingdomCards
    {
        public static CardDecorator Market => new PlusDrawCard(1,
                                              new PlusActionCard(1,
                                              new PlusBuyCard(1,
                                              new PlusMoneyCard(1,
                                              new BaseCard()))))
                            { Name = "Market", Type = "Action"};

    }
}
