using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class balanceHistory_response
    {
        public BalanceHistoryList data;
        public List<object> notifications;
    }
}
