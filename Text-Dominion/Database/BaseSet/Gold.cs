using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Players.Interface;

namespace Text_Dominion.Database.BaseSet
{
    class Gold : ICard
    {
        public const byte Cost = 6;
        public const byte PlayValue = 3;
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
