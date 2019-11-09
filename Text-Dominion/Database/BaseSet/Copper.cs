using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Players.Interface;

namespace Text_Dominion.Database.BaseSet
{
    public class Copper : AbstractCard
    {
        //Note: this is almost entirely boiler-plate code repeated in Silver and Gold
        //See AbstractCard for a way to reduce this.
        //Then calling some sort Factory to create a Copper could create it like so:
        // var copper = new ConcreteCard(0,1,"Treasure");

        public const byte Cost = 0;
        public const byte PlayValue = 1;
        public const string Type = "Treasure";
    }
}
