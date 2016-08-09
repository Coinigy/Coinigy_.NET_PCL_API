using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class OrderType
    {
        public string order_type_id;
        public string name;
        public string order;
    }
}
