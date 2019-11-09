using System.Collections.Generic;
using Text_Dominion.Components.Card.Abstraction;

namespace Text_Dominion.Players.Interface
{
    public interface IPlayer
    {
        void Draw(byte numberOfCardsToDraw);
        void Buy(ICard card);
        void Gain(ICard card);
        void Play(ICard card);
        void Discard(ICard card);
        void Reveal(ICard card);
        string GetType(ICard card);

        void Trash(ICard card);
    }
}
