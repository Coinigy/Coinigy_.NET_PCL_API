using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class DataBid
    {
        public string price;
        public string quantity;
        public string total;
    }
}