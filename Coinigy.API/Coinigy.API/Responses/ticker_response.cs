using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class ticker_response : BaseResponse
    {
        public List<Ticker> data;
        public List<object> notifications;
    }
}