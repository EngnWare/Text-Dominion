using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Player.Interface;

namespace Text_Dominion.Components.Card
{
    public class TreasureCard : ICard
    {
        public byte TreasureValue { get; }
        public IPlayer Player { get; }
        public TreasureCard(byte treasureValue, IPlayer player = null)
        {
            TreasureValue = treasureValue;
            Player = player;
        }

        public void Buy(IPlayer activePlayer)
        {
            throw new System.NotImplementedException();
        }

        public void Discard()
        {
            throw new System.NotImplementedException();
        }

        public void Gain()
        {
            throw new System.NotImplementedException();
        }

        public void IsType()
        {
            throw new System.NotImplementedException();
        }

        public void Play(IPlayer player)
        {
            throw new System.NotImplementedException();
        }

        public void Reveal()
        {
            throw new System.NotImplementedException();
        }

        public void Trash()
        {
            throw new System.NotImplementedException();
        }
    }
}
