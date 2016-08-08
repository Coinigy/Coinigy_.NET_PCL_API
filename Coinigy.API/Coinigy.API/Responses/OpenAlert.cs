using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class OpenAlert
    {
        public string exch_name;
        public string mkt_name;
        public string price;
        public string @operator;
        public string alert_id;
        public string operator_text;
        public string alert_note;
        public string alert_added;
        public string display_name;
        public string exch_code;
    }
}
