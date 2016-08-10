using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class AlertData
    {
        public List<AlertHistory> alert_history;
        public List<OpenAlert> open_alerts;
    }
}