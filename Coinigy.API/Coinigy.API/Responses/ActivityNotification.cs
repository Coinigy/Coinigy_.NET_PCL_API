using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class ActivityNotification
    {
        public string notification_style;
        public string notification_time_added;
        public string notification_title_vars;
        public string notification_type_message;
        public string notification_type_title;
        public string notification_vars;
    }
}