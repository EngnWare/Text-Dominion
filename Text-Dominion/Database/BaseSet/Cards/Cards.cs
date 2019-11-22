using System.Collections.Generic;
using Text_Dominion.Components.Card;
using Text_Dominion.Players;

namespace Text_Dominion.Database.BaseSet.Cards
{
    public class Sentry : BaseCard
    {
        public override void Play(Player player)
        {
            player.Draw(PlusCards);
            player.Actions += PlusActions;
            var revealedCards = player.Deck.Reveal(2);
            //ask for user input to trash
            //ask for user input to discard
            //put cards back onto deck
        }
    }

    public class Harbinger : BaseCard
    {
        public override void Play(Player player)
        {
            player.Draw(PlusCards);
            player.Actions += PlusActions;
            var revealedCards = player.DiscardPile.Reveal(); //reveal whole discard pile
            //ask for user input to topdeck y/n
            //ask for user input which card to topdeck
            //put cards back onto deck
        }
    }

    //TODO: ? Need a player interactions class for reveal, discard, trash, from hand, deck, etc.
    public class Cellar : BaseCard
    {
        public override void Play(Player player)
        {
            player.Actions += PlusActions;
            var dicardedCount = player.Hand.DiscardNumberFromHand();
            player.Draw(PlusCards);
        }
    }
    public class Vassal : BaseCard
    {
        public override void Play(Player player)
        {
            player.Treasure += PlusTreasure;
            BaseCard discardedCard = player.Deck.DiscardFromDeck(1);
            if (discardedCard.Types.Contains("Action Enum"))
            {
                var iety = "remove from discard and play to play area";
            }
        }
    }

    public class Chapel : BaseCard
    {
        public override void Play(Player player)
        {
            player.Hand.TrashFromHandUpTo(4);
        }
    }

    public class Mine : BaseCard
    {
        public override void Play(Player player)
        {
            BaseCard treasureTrashed = player.Hand.TrashATreasure(1);
            player.GainTreasureFromSupplyCostingUpTo(treasureTrashed.Cost + 3).ToHand();
        }
    }

    public class Remodel : BaseCard
    {
        public override void Play(Player player)
        {
            BaseCard cardTrashed = player.Hand.Trash(1);
            GainFromSupplyCostingUpTo(cardTrashed.Cost + 2);
        }
    }

    public class MoneyLender : BaseCard
    {
        public override void Play(Player player)
        {
            if (TrashCopperFromHand)
            {
                player.Treasure += 3;
            }
        }
    }

    public class WorkShop : BaseCard
    {
        public override void Play(Player player)
        {
            //Gain a card costing up to 4
        }
    }

    public class Library : BaseCard
    {
        public override void Play(Player player)
        {
            //While hand.count < 7
            //deck.Reveal(1)
            //IfAction.AskToKeep
            //Else Hand.Add(card)
        }
    }

    public class Poacher : BaseCard
    {
        public override void Play(Player player)
        {
            player.Draw(PlusCards);
            player.Actions += PlusActions;
            player.Treasure += PlusTreasure;
            //var emptyCount = Table.EmptySupplyPiles.Count()
            //Have player discard 1 per emptyCount
        }
    }

    public class Merchant : BaseCard
    {
        public override void Play(Player player)
        {
            player.Draw(PlusCards);
            player.Actions += PlusActions;
            //make player listen for a silver played. ...That sounds difficult
        }
    }
}
