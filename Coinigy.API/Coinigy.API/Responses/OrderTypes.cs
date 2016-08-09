using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class OrderTypes
    {
        public List<OrderType> order_types;
        public List<PriceType> price_types;
    }
}
