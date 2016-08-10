using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class addApiKey_response : BaseResponse
    {
        public long data;
        public List<Notification> notifications;
    }
}
