using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Player.Interface;

namespace Text_Dominion.Components.Card
{
    public class CostCard : ICard
    {
        private readonly byte Cost;

        public ICard Card { get; }

        public CostCard(byte cost, ICard? card = null)
        {
            Cost = cost;
            Card = card;
        }

        public void Buy(IPlayer activePlayer)
        {
            activePlayer.Treasure -= Cost;
            Card?.Buy(activePlayer); //Hm. The fact that this reads the reverse of "player buys card" makes me think 
                                    // I may have implemented in reverse. Dependency Inversion Principle.
            //if a debt card, this would have activePlayer.Debt += Debt;
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
