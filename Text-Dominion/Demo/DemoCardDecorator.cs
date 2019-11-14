using System;
using Text_Dominion.Components.Card.Abstraction;

namespace CrypDominion.Demo
{
    public static class DemoCarDecorator
    {
        public static void Run()
        {
            var silver = new PlusMoneyCard(2, new CostCard(1, new BaseCard()))
            {
                Name = "Silver",
                //Cost = 1,
                PlusMoney = 2
            };
            Console.WriteLine("Let's buy then play a fully implemented silver.");
            //Console.WriteLine(silver.Buy());
            //Console.WriteLine(silver.Play());
        }
    }
}
