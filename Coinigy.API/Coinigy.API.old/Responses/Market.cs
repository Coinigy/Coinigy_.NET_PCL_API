using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class Market
    {
        public string exch_code;
        public string exch_id;
        public string exch_name;
        public string exchmkt_id;
        public string mkt_id;
        public string mkt_name;
    }
}