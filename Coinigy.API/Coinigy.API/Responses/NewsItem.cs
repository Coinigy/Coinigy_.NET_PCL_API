using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class NewsItem
    {
        public string id;
        public string url;
        public string title;
        public string pubDate;
        public string timestamp;
        public string feed_id;
        public string published_date;
        public string feed_name;
        public string feed_url;
        public string feed_enabled;
        public string feed_description;
        public string url_field;
        public string title_field;
        public string date_field;
        public string feed_image;
    }
}
