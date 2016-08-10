using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class data_response : BaseResponse
    {
        public Data data;
        public List<object> notifications;
    }
}
