using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class PriceType
    {
        public string price_type_id;
        public string name;
        public string order;
    }
}
