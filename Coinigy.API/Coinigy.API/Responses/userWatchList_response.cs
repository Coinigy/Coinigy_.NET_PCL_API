using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class userWatchList_response : BaseResponse
    {
        public List<WatchedItem> data;
        public List<object> notifications;
    }
}
