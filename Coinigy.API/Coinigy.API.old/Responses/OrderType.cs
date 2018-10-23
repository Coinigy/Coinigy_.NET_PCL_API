using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class OrderType
    {
        public string name;
        public string order;
        public string order_type_id;
    }
}