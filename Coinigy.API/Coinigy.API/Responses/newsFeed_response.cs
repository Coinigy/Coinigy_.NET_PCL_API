using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class newsFeed_response
    {
        public List<NewsItem> data;
        public List<object> notifications;
    }
}
