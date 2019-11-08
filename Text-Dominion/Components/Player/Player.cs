using System.Collections.Generic;
using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Player.Interface;

namespace Text_Dominion.Player
{
    public class Player : IPlayer
    {
        //private readonly ITable _table;
        //private readonly IDominionFactory _factory;

        //public Player(ITable table, IDominionFactory factory)
        //{
        //    _table = table ?? throw new ArgumentNullException(nameof(table));
        //    _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        //}
        public List<ICard> Deck { get; set; }
        public List<ICard> DiscardPile { get; set; }
        public List<ICard> Hand { get; set; }
        public byte Treasure = 1;
        public byte Actions = 1;
        public byte Buys = 1;
        public byte Debt = 1;

        public void BuyCard(ICard card)
        {
            //TODO: do a thing
        }

        public void PlayCard(ICard card)
        {
            //TODO: do a thing
        }
    }
}
