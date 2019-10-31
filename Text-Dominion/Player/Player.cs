using System;
using System.Collections.Generic;
using Text_Dominion.Dominion.Interface;
using Text_Dominion.Factory.Interface;
using Text_Dominion.Interface;
using Text_Dominion.Player.Interface;

namespace Text_Dominion.Player
{
    public class Player : IPlayer
    {
        private readonly ITable _table;
        private readonly IDominionFactory _factory;

        public Player(ITable table, IDominionFactory factory)
        {
            _table = table ?? throw new ArgumentNullException(nameof(table));
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }
        
        public List<ICard> Deck { get; set; }
        public List<ICard> DiscardPile { get; set; }
        public List<ICard> Hand { get; set; }
        public byte Money { get; set; }
        public byte Actions { get; set; }
        public byte Buys { get; set; }

        public void BuyCard(ref ICard card)
        {
            
        }

        public void DiscardCard(ref ICard card)
        {
            
        }

        public void DrawCard(byte drawCount)
        {
            
        }

        public void GainCard(ref ICard card)
        {
            
        }

        public void PlayCard(ref ICard card)
        {
            
        }

        public void TrashCard(ref ICard card)
        {
            
        }
    }
}
