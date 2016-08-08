using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class WatchedItem
    {
        public string exchmkt_id;
        public string mkt_name;
        public string exch_code;
        public string exch_name;
        public string primary_currency_name;
        public string secondary_currency_name;
        public string server_time;
        public string last_price;
        public string prev_price;
        public string high_trade;
        public string low_trade;
        public string current_volume;
        public string fiat_market;
        public string btc_volume;
    }
}
