using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class WatchedItem
    {
        public string btc_volume;
        public string current_volume;
        public string exch_code;
        public string exch_name;
        public string exchmkt_id;
        public string fiat_market;
        public string high_trade;
        public string last_price;
        public string low_trade;
        public string mkt_name;
        public string prev_price;
        public string primary_currency_name;
        public string secondary_currency_name;
        public string server_time;
    }
}