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
        //public byte Treasure { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public byte Treasure
        {
            get { return _treasure; }
            set { _treasure = value; }
        }
        private byte _treasure;

        public byte Debt
        {
            get { return _debt; }
            set { _debt = value; }
        }
        private byte _debt;

        public byte Buys
        {
            get { return _buys; }
            set { _buys = value; }
        }
        private byte _buys;

        public byte Actions
        {
            get { return _actions; }
            set { _actions = value; }
        }
        private byte _actions;

        public void BuyCard(ICard card)
        {
            //TODO: do a thing
        }

        public void PlayCard(ICard card)
        {
            card.Play(this);
        }
    }
}
