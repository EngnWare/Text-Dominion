using System;
using System.Collections.Generic;
using Text_Dominion.Dominion.Interface;

namespace Text_Dominion.Interface
{
    public interface ITable
    {
        List<object> obj { get; set; }

        void Setup(List<ICard> cards);
        void NextTurn();
    }
}
