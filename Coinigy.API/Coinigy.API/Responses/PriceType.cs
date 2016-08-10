using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class PriceType
    {
        public string name;
        public string order;
        public string price_type_id;
    }
}