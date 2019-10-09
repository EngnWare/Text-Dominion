using System.Collections.Generic;
using Text_Dominion.Domain.Dominion.Models;
using Text_Dominion.Domain.Player.Models;
using Text_Dominion.Domain.Table.Extensions;

namespace Text_Dominion.Domain.Table.Models
{
    public class KingdomCardSlotModel
    {
        public const byte MAX_CARD_COUNT = 10;
        public const byte MIN_CARD_COUNT = 0;

        public readonly CardModel DisplayCard;

        public List<CardModel> Cards { get; set; }
        public bool IsEmpty => Cards.Count == MIN_CARD_COUNT;

        public KingdomCardSlotModel(CardModel chosenCardModel)
        {
            Cards = chosenCardModel.CreateStack();
            DisplayCard = chosenCardModel;
        }

        public void TakeCard(ref PlayerModel player, ref CardModel card)
        {

        }
    }
}
