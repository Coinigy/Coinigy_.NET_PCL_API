using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class newsFeed_response : BaseResponse
    {
        public List<NewsItem> data;
        public List<object> notifications;
    }
}
