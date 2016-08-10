using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class DataHistory
    {
        public string price;
        public string quantity;
        public string time_local;
        public string type;
    }
}
