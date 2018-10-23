using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class refreshBalance_response : BaseResponse
    {
        public List<Balance> data;
        public List<object> notifications;
    }
}