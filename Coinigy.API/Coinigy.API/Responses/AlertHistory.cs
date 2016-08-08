using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class AlertHistory
    {
        public string exch_name;
        public string mkt_name;
        public string price;
        public string @operator;
        public string alert_history_id;
        public string timestamp;
        public string alert_price;
        public string operator_text;
        public string alert_note;
        public string display_name;
    }
}
