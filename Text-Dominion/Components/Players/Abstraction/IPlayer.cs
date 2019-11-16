using Text_Dominion.Components.Card.Abstraction;

namespace Text_Dominion.Components.Players.Abstraction
{
    public interface IPlayer
    {
        //void Draw(byte numberOfCardsToDraw);
        void Buy(AbstractCard card);
        //void Gain(AbstractCard card);
        //void Play(AbstractCard card);
        //void Discard(AbstractCard card);
        //void Reveal(AbstractCard card);
        //string GetType(AbstractCard card);

        //void Trash(AbstractCard card);
    }
}
