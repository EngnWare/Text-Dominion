using Text_Dominion.Player.Interface;

namespace Text_Dominion.Components.Card.Abstraction
{
    internal interface IPlayCard : ICard
    {
        void Play(IPlayer player);
    }
}
