using System;
using System.Collections.Generic;
using Text_Dominion.Domain.Player.Models;
using Text_Dominion.Domain.Table.Models;

namespace Text_Dominion.Domain.Dominion.Tools
{
    public class KingdomGenerator
    {
        public const byte NUMBER_OF_KINGDOM_CARDS = 10;

        public readonly byte _numberOfVictoryCards;

        public KingdomGenerator(ref List<PlayerModel> players)
        {
            _numberOfVictoryCards = (byte)((players.Count - 1) * 10);
        }

        public void Generate(ref TableModel table)
        {

        }
    }
}
