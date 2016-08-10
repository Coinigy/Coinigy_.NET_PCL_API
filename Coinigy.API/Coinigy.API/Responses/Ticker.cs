using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class Ticker
    {
        public string ask;
        public string bid;
        public string current_volume;
        public string exchange;
        public string high_trade;
        public string last_trade;
        public string low_trade;
        public string market;
        public string timestamp;
    }
}