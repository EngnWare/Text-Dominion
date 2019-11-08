using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Player.Interface;

namespace Text_Dominion.Components.Card
{
    public class DebtCard : IBuyCard
    {
        private readonly byte _debt;
#nullable enable
        private readonly IBuyCard? _card;

        public DebtCard(byte debt, IBuyCard? card = null)
        {
            _debt = debt;
            _card = card;
        }
        public void Buy(IPlayer activePlayer)
        {
            //activePlayer.Debt += _debt;
            //_card?.Buy(ref activePlayer);
        }
    }
}
