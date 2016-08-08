using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class alerts_response
    {
        public AlertData data;
        public List<object> notifications;
    }
}
