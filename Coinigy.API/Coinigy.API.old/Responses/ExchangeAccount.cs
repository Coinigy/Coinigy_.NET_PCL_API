using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class ExchangeAccount
    {
        public string auth_active;
        public string auth_id;
        public string auth_key;
        public string auth_nickname;
        public string auth_optional1;
        public string auth_secret;
        public string auth_trade;
        public string auth_updated;
        public string exch_id;
        public string exch_name;
        public string exch_trade_enabled;
    }
}