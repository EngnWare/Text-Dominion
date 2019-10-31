using System;
using Text_Dominion.Factory.Interface;
using Text_Dominion.Service.Interface;

namespace Text_Dominion.Service
{
    public class TableService : ITableService
    {
        private readonly IDominionFactory _dominionFactory;

        public TableService(IDominionFactory dominionFactory)
        {
            _dominionFactory = dominionFactory;
        }


    }
}
