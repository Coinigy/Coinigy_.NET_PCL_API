using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class Orders
    {
        public List<OpenOrder> open_orders;
        public List<OrderHistory> order_history;
    }
}