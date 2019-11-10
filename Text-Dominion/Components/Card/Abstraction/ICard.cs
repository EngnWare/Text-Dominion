using Text_Dominion.Players;

namespace Text_Dominion.Components.Card.Abstraction
{
    public interface ICard
    {
        /*
         * Perhaps separate into 
         * 1. PlayerInteractions (buy, play, etc.), 
         * 2. cardProperties (IsVictory, IsPlayable, etc.)
         * 3. 
         */
        void Buy(Player player);
        void Gain(Player player);
        void Play(Player player);
        void Discard(Player player);
        void Reveal(Player player);
        string GetCardType();
        void Trash(Player player);
        bool IsPlayable(Player player);
    }
}
