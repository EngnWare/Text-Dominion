using System;
using System.Collections.Generic;
using Text_Dominion.Domain.Dominion.Models;

namespace Text_Dominion.Domain.Table.Models
{
    public class TreasureCardSlotModel
    {
        public readonly byte _maxCardCount;

        public readonly CardModel DisplayCard;

        public List<CardModel> Cards { get; set; }

        public TreasureCardSlotModel(CardModel treasureCard)
        {
            if(treasureCard.Types.Contains(CardTypes.Treasure))
            {

            }
        }
    }
}
