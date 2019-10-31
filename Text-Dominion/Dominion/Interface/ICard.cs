using System;
using System.Collections.Generic;
using Text_Dominion.Dominion.Enums;
using Text_Dominion.Player.Interface;

namespace Text_Dominion.Dominion.Interface
{
    public interface ICard
    {
        string Title { get; set; }
        string Description { get; set; }
        public byte Cost { get; set; }
        List<CardType> Types { get; set; }

        public void PlayCardAction(ref IPlayer player);
    }
}
