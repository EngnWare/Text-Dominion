using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Players;

namespace Text_Dominion.Components.Card
{

    public class BaseCard : AbstractCard
    {
        //every card has...
        //public string Name;
        //public list<type> Types;
        //...but not sure anything else is guaranteed but...
        /*
         * I am strongly considering setting buys, actions, cost, plusMoney, etc.
         * as properties in the base class.
         * ...Man, Decorator syntax is such a mess.
         */

        public override void Buy(Player player)
        {
            //Add one to GainCount
            //player.DiscardPile.Add(this);

        }
        //public override void Gain(Player player)
        //{
        //    //Add one to GainCount
        //    player.DiscardPile.Add(this);
        //}

        //public override void Play(Player player)
        //{
        //    player.PlayPile.Add(this);
        //}
        //public void Discard(Player player)
        //{
        //    //TODO: what's responsible for knowing where the card already is? (deck, hand, play field...)
        //    //Maybe make a Player.ActiveCard s.t. the card in question is just added to DiscardPile
        //    player.DiscardPile.Remove(this);
        //    player.DiscardPile.Add(this);
        //}

        //public string GetCardType()
        //{
        //    return this.Type;
        //}

        //public bool IsPlayable(Player player)
        //{
        //    return true;
        //}

        //public void Reveal(Player player)
        //{
        //    //TODO: display details?
        //}

        //public void Trash(Player player)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
