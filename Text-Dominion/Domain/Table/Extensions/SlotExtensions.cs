using System.Collections.Generic;
using System.Linq;
using Text_Dominion.Domain.Dominion.Models;

namespace Text_Dominion.Domain.Table.Extensions
{
    public static class SlotExtensions
    {
        /// <summary>
        /// Creates the stack of ten cards, used during game setup.
        /// </summary>
        /// <param name="chosenCard"></param>
        /// <returns></returns>
        public static List<CardModel> CreateStack(this CardModel chosenCard)
        {
            var stack = new List<CardModel>();

            for(byte i = 1; i < 10; i++)
            {
                var card = new CardModel
                {
                    CardName = chosenCard.CardName,
                    Cost = chosenCard.Cost,
                    PlusActions = chosenCard.PlusActions,
                    PlusCards = chosenCard.PlusCards,
                    PlusMoney = chosenCard.PlusMoney,
                    PlusBuys = chosenCard.PlusBuys,
                    Types = chosenCard.Types.Select(x => x).ToList(),
                    CardAction = chosenCard.CardAction
                };

                stack.Add(card);
            }

            return stack;
        }
    }
}
