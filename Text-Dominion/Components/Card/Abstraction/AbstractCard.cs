using Text_Dominion.Player.Interface;

namespace Text_Dominion.Components.Card.Abstraction
{
    public abstract class AbstractCard
    {
        public byte Cost;
        public byte PlayValue;
        public string Type;

        public void Buy(IPlayer activePlayer)
        {
            activePlayer.Treasure -= Cost;
        }

        public void Play(IPlayer player)
        {
            player.Treasure += PlayValue;
        }
    }

    public class ConcreteCard : AbstractCard
    {
        public ConcreteCard(byte cost, byte playValue, string type)
        {
            Cost = cost;
            PlayValue = playValue;
            Type = type; //Make a readonly list;
        }
    }

    public class DebtCard : AbstractCard
    {
        private byte Debt;

        //demonstration of idea
        public DebtCard(byte cost, byte playValue, string type, byte debt)
        {
            Cost = cost;
            PlayValue = playValue;
            Type = type; //Make a readonly list;
            Debt = debt;
        }

        public new void Buy(IPlayer player)
        {
            player.Debt += Debt;
        }
    }
}
