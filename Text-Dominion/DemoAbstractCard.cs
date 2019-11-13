namespace CrypDominion
{
    public static class DemoAbstractCard
    {
        public static void Run()
        {
            var copper = new Copper();
            copper.Buy();
            copper.Play();

            var engineer = new Engineer();
            engineer.Buy();
            engineer.Play();

            BuyCard(copper);
            PlayCard(copper);

            BuyCard(engineer);
            PlayCard(engineer);
        }

        public static void BuyCard(AbstractCard card)
        {
            card.Buy();
        }

        public static void PlayCard(AbstractCard card)
        {
            card.Play();
        }
    }
}
