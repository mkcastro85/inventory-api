using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_api.Dto
{
    public class InventoryDTO
    {
        public List<string> Equinos { get; set; }
        public List<string> Bovinos { get; set; }
    }
}
