using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class Balance
    {
        public string balance_curr_code;
        public string balance_amount_avail;
        public string balance_amount_held;
        public string balance_amount_total;
        public string btc_balance;
        public string last_price;
    }
}
