using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class AlertHistory
    {
        public string alert_history_id;
        public string alert_note;
        public string alert_price;
        public string display_name;
        public string exch_name;
        public string mkt_name;
        public string @operator;
        public string operator_text;
        public string price;
        public string timestamp;
    }
}