using System;
using System.Collections.Generic;
using Text_Dominion.Domain.Dominion.Models;

namespace Text_Dominion.Domain.Table.Models
{
    public class TrashSlotModel
    {
        public byte CardCount => (byte)TrashedCards.Count;

        public List<CardModel> TrashedCards { get; set; } = new List<CardModel>();

        public TrashSlotModel()
        {

        }

        public void TrashCard(ref CardModel card)
        {
            TrashedCards.Add(card);
        }
    }
}
