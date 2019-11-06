using Text_Dominion.Player.Interface;

namespace Text_Dominion.Components.Card.Abstraction
{
    public interface IBuyCard
    {
        void Buy(IPlayer activePlayer);
    }
}
