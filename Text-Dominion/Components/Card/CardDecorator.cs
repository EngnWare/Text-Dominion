using Text_Dominion.Players;

namespace Text_Dominion.Components.Card
{
    public class CardDecorator : BaseCard
    {
        protected BaseCard DecoratedCard;

        public CardDecorator(BaseCard decoratedCard)
        {
            DecoratedCard = decoratedCard;
        }

        public override void Buy(Player player)
        {
            DecoratedCard.Buy(player);
        }

        //public new void Gain(Player player)
        //{
        //    DecoratedCard.Gain(player);
        //}

        //public new void Play(Player player)
        //{
        //    DecoratedCard.Play(player);
        //}
        //public new void Discard(Player player)
        //{
        //    DecoratedCard.Discard(player);
        //}

        //public new string GetCardType()
        //{
        //    return DecoratedCard.GetCardType();
        //}

        //public new bool IsPlayable(Player player)
        //{
        //    return DecoratedCard.IsPlayable(player);
        //}

        //public new void Reveal(Player player)
        //{
        //    DecoratedCard.Reveal(player);
        //}

        //public new void Trash(Player player)
        //{
        //    DecoratedCard.Trash(player);
        //}
    }
}
