using System.Collections.Generic;
using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Players.Interface;

namespace Text_Dominion.Players
{
    public class Player : IPlayer
    {
        public List<ICard> Deck { get; set; }
        public List<ICard> Hand { get; set; }
        public List<ICard> CardsInPlay { get; set; }
        public List<ICard> DiscardPile { get; set; }

        public byte Treasure { get; set; }
        public byte Actions { get; set; }
        public byte Buys { get; set; }
        public byte Debt { get; set; }

        public void Draw(byte numberOfCardsToDraw)
        {

        }

        public void Buy(ICard card)
        {
            card.Buy(this);
        }

        public void Gain(ICard card)
        {
            card.Gain(this);
        }

        public void Play(ICard card)
        {
            card.Play(this);
        }
        public void Discard(ICard card)
        {
            card.Discard(this);
        }
        public void Reveal(ICard card)
        {
            card.Reveal(this);
        }
        public string GetType(ICard card)
        {
            return card.GetCardType();
        }

        public void Trash(ICard card)
        {

        }
    }
}
