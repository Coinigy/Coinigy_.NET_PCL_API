using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class NewsItem
    {
        public string date_field;
        public string feed_description;
        public string feed_enabled;
        public string feed_id;
        public string feed_image;
        public string feed_name;
        public string feed_url;
        public string id;
        public string pubDate;
        public string published_date;
        public string timestamp;
        public string title;
        public string title_field;
        public string url;
        public string url_field;
    }
}