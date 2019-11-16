using Text_Dominion.Components.Card;
using Text_Dominion.Components.Card.Abstraction;

namespace Text_Dominion.Database.BaseSet
{
    public static class Treasures
    {
        public static CardDecorator Copper => new PlusMoneyCard(1, new CostCard(0, new BaseCard()))
        {
            Name = "Copper",
            Type = "Treasure",
            //Cost = 0,
            //PlusMoney = 2
        };
        public static CardDecorator Silver => new PlusMoneyCard(2, new CostCard(3, new BaseCard()))
        {
            Name = "Silver",
            Type = "Treasure",
            //Cost = 3,
            //PlusMoney = 2
        };
        public static CardDecorator Gold => new PlusMoneyCard(3, new CostCard(6, new BaseCard()))
        {
            Name = "Gold",
            Type = "Treasure",
            //Cost = 6,
            //PlusMoney = 2
        };



        //public CostCard GetCopper()
        //{
        //    return new CostCard()
        //    {
        //        Name = "Copper",
        //        Cost = 0,
        //        Type = "Treasure"
        //    };
        //}
        //public ConcreteCard Copper => new ConcreteCard(0, 1, "Treasure");
        //public ConcreteCard Silver => new ConcreteCard(3, 2, "Treasure");
        //public ConcreteCard Gold => new ConcreteCard(6, 3, "Treasure");

    }
}
