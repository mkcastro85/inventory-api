using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_api.Exceptions
{
    [Serializable()]
    public class InventoryException : System.Exception
    {
        public InventoryException() : base() { }
        public InventoryException(string message) : base(message) { }
        public InventoryException(string message, System.Exception inner) : base(message, inner) { }

        protected InventoryException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
