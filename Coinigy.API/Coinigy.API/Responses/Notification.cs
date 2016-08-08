using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class Notification
    {
        public string notification_id;
        public string notification_type_title;
        public string notification_type_message;
        public string notification_style;
        public string notification_vars;
        public string notification_title_vars;
        public string notification_pinned;
        public string notification_sound;
        public string notification_sound_id;
    }
}
