using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class activity_response : BaseResponse
    {
        public List<ActivityNotification> data;
        public List<object> notifications;
    }
}
