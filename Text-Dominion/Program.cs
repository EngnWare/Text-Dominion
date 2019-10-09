using System;
using System.Collections.Generic;
using Text_Dominion.Domain.Player.Models;
using Text_Dominion.Domain.Table.Models;

namespace Text_Dominion
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new TableModel();

            var players = new List<PlayerModel>();

            var canContinue = false;

            do
            {
                //get player info until done adding players.
            } while (!canContinue);

            table.SetupGame();
        }
    }
}
