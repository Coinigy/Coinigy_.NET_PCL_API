using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class markets_response : BaseResponse
    {
        public List<Market> data;
        public List<object> notifications;
    }
}