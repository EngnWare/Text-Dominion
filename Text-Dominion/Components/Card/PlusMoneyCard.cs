namespace Text_Dominion.Components.Card
{
    public class PlusMoneyCard : CardDecorator
    {
        public byte PlusMoney;

        public PlusMoneyCard(byte plusMoney, BaseCard card) : base(card)
        {
            PlusMoney = plusMoney;
        }

        //public override bool Play()
        //{
        //    Console.WriteLine($"Add {PlusTreasure} treasures to player.");
        //    return DecoratedCard.Play();
        //}
    }
}
