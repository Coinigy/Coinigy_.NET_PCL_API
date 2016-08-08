using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class OpenOrder
    {
        public string exch_name;
        public string mkt_name;
        public string limit_price;
        public string @operator;
        public string order_id;
        public string order_type;
        public string order_price_type;
        public string order_status;
        public string quantity;
        public string order_time;
        public string foreign_order_id;
        public string auth_nickname;
        public string auth_id;
        public string quantity_remaining;
        public string stop_price;
        public string price_type_id;
        public string exch_code;
        public string display_name;
    }
}
