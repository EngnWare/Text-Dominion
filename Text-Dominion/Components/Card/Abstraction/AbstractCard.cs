using Text_Dominion.Players;

namespace Text_Dominion.Components.Card.Abstraction
{
    public abstract class AbstractCard
    {
        public string Name;
        public string Type;

        public abstract void Buy(Player player);
        //public abstract void Gain(Player player);
        //public abstract void Play(Player player);
        //public abstract void Discard(Player player);
        //public abstract void Reveal(Player player);
        //public abstract string GetCardType();
        //public abstract void Trash(Player player);
        //public abstract bool IsPlayable(Player player);
    }
}
