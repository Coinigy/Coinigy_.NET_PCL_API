using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class BaseResponse
    {
        public string err_num;
        public string err_msg;
    }
}
