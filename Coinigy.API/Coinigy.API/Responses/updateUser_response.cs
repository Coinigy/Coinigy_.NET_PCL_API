using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class updateUser_response
    {
        public object data;
        public List<Notification> notifications;
    }
}
