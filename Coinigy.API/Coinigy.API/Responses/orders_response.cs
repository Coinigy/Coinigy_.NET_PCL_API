using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class orders_response : BaseResponse
    {
        public Orders data;
        public List<object> notifications;
    }
}