using Text_Dominion.Database.BaseSet;
using Text_Dominion.Player;

namespace Text_Dominion.Demo
{
    public class Demo1
    {
        //add code here to demonstrate play and such.
        public void Demo()
        {
            var player1 = new Player.Player();
            var copper = new Copper();
            System.Console.WriteLine(player1.Treasure);
            player1.PlayCard(copper);
            System.Console.WriteLine(player1.Treasure);

        }
    }
}
