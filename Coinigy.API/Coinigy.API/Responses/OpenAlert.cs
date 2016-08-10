using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class OpenAlert
    {
        public string alert_added;
        public string alert_id;
        public string alert_note;
        public string display_name;
        public string exch_code;
        public string exch_name;
        public string mkt_name;
        public string @operator;
        public string operator_text;
        public string price;
    }
}