using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class balances_response
    {
        public List<Balance> data;
        public List<object> notifications;
    }
}