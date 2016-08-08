using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class UserInfo
    {
        public string email;
        public string active;
        public string last_login;
        public string chat_enabled;
        public string chat_nick;
        public string ticker_enabled;
        public string ticker_indicator_time_type;
        public string custom_ticker;
        public string first_name;
        public string last_name;
        public string last_active;
        public string pref_subscription_expires;
        public string pref_alert_email;
        public string pref_alert_sms;
        public string pref_trade_email;
        public string pref_trade_sms;
        public string pref_alert_mobile;
        public string pref_trade_mobile;
        public string pref_balance_email;
        public string pref_referral_code;
        public string created_on;
        public string company;
        public string phone;
        public string street1;
        public string street2;
        public string city;
        public string state;
        public string zip;
        public string country;
        public string newsletter;
        public string two_factor;
        public string subscription_status;
        public string referral_balance;
        public bool pref_app_device_id;
    }
}
