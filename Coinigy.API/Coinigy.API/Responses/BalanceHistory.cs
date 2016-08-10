using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class BalanceHistory
    {
        public string auth_id;
        public string balance_amount_avail;
        public string balance_amount_held;
        public string balance_amount_total;
        public string balance_curr_code;
        public string balance_date;
        public string btc_value;
        public string timestamp;
    }
}