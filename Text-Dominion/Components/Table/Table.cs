using System;
using System.Collections.Generic;
using System.Text;
using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Players.Interface;

namespace Text_Dominion.Components.Table
{
    public class Table
    {
        public List<ICard> TreasureCards { get; set; }
        public List<IPlayer> Players { get; set; }
        //public Kingdom Kingdom { get; set; }

    }
}
