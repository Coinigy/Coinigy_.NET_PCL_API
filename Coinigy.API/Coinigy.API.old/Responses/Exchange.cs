using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class Exchange
    {
        public string exch_balance_enabled;
        public string exch_code;
        public string exch_fee;
        public string exch_id;
        public string exch_name;
        public string exch_trade_enabled;
        public string exch_url;
    }
}