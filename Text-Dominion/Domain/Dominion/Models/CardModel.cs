using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Text_Dominion.Domain.Player.Models;

namespace Text_Dominion.Domain.Dominion.Models
{
    public class CardModel
    {
        public string CardName { get; set; }

        public byte Cost { get; set; }

        public byte PlusActions { get; set; }

        public byte PlusCards { get; set; }

        public byte PlusMoney { get; set; }

        public byte PlusBuys { get; set; }

        public List<CardTypes> Types { get; set; }

        public Func<PlayerModel, Task> CardAction { get; set; }
    }
}
