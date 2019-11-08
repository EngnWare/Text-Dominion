using Text_Dominion.Components.Card.Abstraction;

namespace Text_Dominion.Player.Interface
{
    public interface IPlayer
    {
        //List<ICard> Deck { get; set; }
        //List<ICard> DiscardPile { get; set; }
        //List<ICard> Hand { get; set; }

        //byte Treasure { get; set; }
        //byte Actions { get; set; }
        //byte Buys { get; set; }
        //byte Debt { get; set; }

        //void TrashCard(ref ICard card);
        //void DiscardCard(ref ICard card);
        void PlayCard(ICard card);
        void BuyCard(ICard card);
        //void GainCard(ref ICard card);

        //void DrawCard(byte drawCount);
    }
}
