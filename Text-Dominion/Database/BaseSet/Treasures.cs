using Text_Dominion.Components.Card;
using Text_Dominion.Components.Card.Abstraction;

namespace Text_Dominion.Database.BaseSet
{
    public class Treasures
    {
        public CostCard GetCopper()
        {
            return new CostCard()
            {
                Name = "Copper",
                Cost = 0,
                Type = "Treasure"
            };
        }
        //public ConcreteCard Copper => new ConcreteCard(0, 1, "Treasure");
        //public ConcreteCard Silver => new ConcreteCard(3, 2, "Treasure");
        //public ConcreteCard Gold => new ConcreteCard(6, 3, "Treasure");

    }
}
