using System;
using System.Collections.Generic;
using Text_Dominion.Domain.Dominion.Models;
using Text_Dominion.Domain.Player.Models;

namespace Text_Dominion.Domain.Dominion.AllCards
{
    public class Smithy : CardModel
    {
        public Smithy() : base()
        {
            CardName = nameof(Smithy);
            Cost = 4;
            PlusActions = 0;
            PlusBuys = 0;
            PlusCards = 3;
            PlusMoney = 0;
        }

        public override void PlayCard(ref PlayerModel currentPlayer, ref List<PlayerModel> otherPlayers)
        {
            
        }

    }
}
