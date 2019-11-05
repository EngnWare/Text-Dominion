using Text_Dominion.Player.Interface;

namespace Text_Dominion.Components.Card.Abstraction
{
    /*
     * In order account for different (or even new) types of cards (action, duration, night, etc.) and 
     * their attributes (cost, debt, in supply, etc.), we intend to use an abstraction layer to employ
     * the Decorator pattern.
     * 
     * Currently return void, but maybe in the future return some sort of printable object which uses a print
     * service to handle console display.
     */
    public interface ICard
    {
        void Buy(IPlayer activePlayer);
        void Gain();
        void Reveal();
        void IsType();
        void Play(IPlayer player);
        void Trash();
        void Discard();

    }
}
