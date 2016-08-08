using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class accounts_response
    {
        public List<ExchangeAccount> data;
        public List<object> notifications;
    }
}
