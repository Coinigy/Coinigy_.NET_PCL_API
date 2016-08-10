using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class Data
    {
        public string exch_code;
        public string primary_curr_code;
        public string secondary_curr_code;
        public string type;
        public List<DataHistory> history;
        public List<DataAsk> asks;
        public List<DataBid> bids;
    }
}
