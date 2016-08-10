using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class DataAsk
    {
        public string price;
        public string quantity;
        public string total;
    }
}