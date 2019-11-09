using System.Collections.Generic;
using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Players.Interface;

namespace Text_Dominion.Players
{
    public class Player : IPlayer
    {
        public List<AbstractCard> Deck { get; set; }
        public List<AbstractCard> Hand { get; set; }
        public List<AbstractCard> CardsInPlay { get; set; }
        public List<AbstractCard> DiscardPile { get; set; }

        public byte Treasure { get; set; }
        public byte Actions { get; set; }
        public byte Buys { get; set; }
        public byte Debt { get; set; }

        public void Draw(byte numberOfCardsToDraw)
        {

        }

        public void Buy(AbstractCard card)
        {
            card.Buy(this);
        }

        public void Gain(AbstractCard card)
        {
            card.Gain(this);
        }

        public void Play(ICard card)
        {
            card.Play(this);
        }
        public void Discard(AbstractCard card)
        {
            card.Discard(this);
        }
        public void Reveal(AbstractCard card)
        {
            card.Reveal(this);
        }
        public string GetType(AbstractCard card)
        {
            return card.GetCardType();
        }

        public void Trash(AbstractCard card)
        {

        }
    }
}
