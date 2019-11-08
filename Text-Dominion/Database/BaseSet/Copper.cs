using Text_Dominion.Components.Card.Abstraction;

namespace Text_Dominion.Database.BaseSet
{
    public class Copper : ICard
    {
        public byte Cost => 0;
        public byte Value => 1;
        public string Type => "Treasure";
    }
}
