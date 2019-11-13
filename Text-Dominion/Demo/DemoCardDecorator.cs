using System;
using Text_Dominion.Components.Card.Abstraction;

namespace CrypDominion.Demo
{
    public static class DemoCarDecorator
    {
        public static void Run()
        {
            /* options for adding a property dynamically:
             * 1. Continue adding properties to the constructor as show below
             * 2. Let the base class have a single dictionary property. "Name":"Copper", Cost:1, etc.
             * 3. Use ExpandoObject (slow and memory intensive though)
             * 4. Find another way
             */
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
