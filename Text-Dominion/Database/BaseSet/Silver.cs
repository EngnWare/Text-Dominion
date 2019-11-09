using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Players.Interface;

namespace Text_Dominion.Database.BaseSet
{
    class Silver : ICard
    {
        public const byte Cost = 3;
        public const byte PlayValue = 2;
        public const string Type = "Treasure";

        public void Buy(IPlayer activePlayer)
        {
            activePlayer.Treasure -= Cost;
        }

        public void Play(IPlayer player)
        {
            player.Treasure += PlayValue;
        }
    }
}
