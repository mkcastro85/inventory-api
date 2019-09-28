using inventory_api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_api.Services.Strategies
{
    interface IStrategyClassify
    {
        InventoryDTO classify(List<string> animals);
    }
}
