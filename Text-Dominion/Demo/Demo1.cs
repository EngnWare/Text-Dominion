using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Database.BaseSet;

namespace Text_Dominion.Demo
{
    public class Demo1
    {
        //add code here to demonstrate play and such.
        public void Demo()
        {
            //Copper demo
            var factory = new Treasures();
            var player1 = new Players.Player();
            var copper = factory.GetCopper();
            System.Console.WriteLine(player1.Treasure);
            player1.Play(copper);
            System.Console.WriteLine(player1.Treasure);

            //Demo of Costcard : BaseCard : ICard 
            var cc = new CostCard();
            player1.Play(cc); //demonstrates that CostCard is still an ICard via inheritance.

            //Demo the decorator
            var plainCard = new BaseCard(); 
        }
    }
}
