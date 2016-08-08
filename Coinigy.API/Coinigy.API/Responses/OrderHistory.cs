using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class OrderHistory
    {
        public string exch_id;
        public string exch_name;
        public string mkt_name;
        public string auth_id;
        public string executed_price;
        public string limit_price;
        public string order_id;
        public string order_type;
        public string order_price_type;
        public string order_status;
        public string quantity;
        public string quantity_remaining;
        public string last_updated;
        public string order_time;
        public string auth_nickname;
        public string exch_code;
        public string display_name;
        public string unixtime;
    }
}
