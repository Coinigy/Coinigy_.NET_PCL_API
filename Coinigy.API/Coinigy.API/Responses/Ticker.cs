using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class Ticker
    {
        public string exchange;
        public string market;
        public string last_trade;
        public string high_trade;
        public string low_trade;
        public string current_volume;
        public string timestamp;
        public string ask;
        public string bid;
    }
}
