using inventory_api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_api.Services.Strategies
{
    class Context
    {
        private IStrategyClassify strategy;

        public Context(IStrategyClassify strategy)
        {
            this.strategy = strategy;
        }

        public InventoryDTO ContextInterface(List<string> animals)
        {
            return strategy.classify(animals);
        }
    }
}
