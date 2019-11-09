using System.Collections.Generic;
using Text_Dominion.Components.Card.Abstraction;

namespace Text_Dominion.Players.Interface
{
    public interface IPlayer
    {
        void Draw(byte numberOfCardsToDraw);
        void Buy(AbstractCard card);
        void Gain(AbstractCard card);
        void Play(ICard card);
        void Discard(AbstractCard card);
        void Reveal(AbstractCard card);
        string GetType(AbstractCard card);

        void Trash(AbstractCard card);
    }
}
