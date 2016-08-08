using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class BalanceHistoryList
    {
        public List<BalanceHistory> balance_history;
    }
}
