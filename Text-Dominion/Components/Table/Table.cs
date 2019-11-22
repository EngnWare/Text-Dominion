using System.Collections.Generic;
using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Components.Players.Abstraction;

namespace Text_Dominion.Components.Table
{
    public class Table
    {
        public List<AbstractCard> TreasureCards { get; set; }
        public List<IPlayer> Players { get; set; }
        //public Kingdom Kingdom { get; set; }

    }
}
