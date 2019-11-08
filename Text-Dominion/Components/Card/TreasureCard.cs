using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Player;
using Text_Dominion.Player.Interface;

namespace Text_Dominion.Components.Card
{
    public class TreasureCard : ICard
    {
        private byte TreasureValue;

        public IBuyCard Card { get; }

#nullable enable
        public TreasureCard(byte treasureValue, ICard? card = null)
        {
            TreasureValue = treasureValue;
            //Card = card;
        }
#nullable disable

        public void Buy(IPlayer player)
        {
            throw new System.NotImplementedException();
        }

        public void Play(IPlayer player)
        {
            throw new System.NotImplementedException();
        }
    }
}
