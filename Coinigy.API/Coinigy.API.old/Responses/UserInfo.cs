using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class UserInfo
    {
        public string active;
        public string chat_enabled;
        public string chat_nick;
        public string city;
        public string company;
        public string country;
        public string created_on;
        public string custom_ticker;
        public string email;
        public string first_name;
        public string last_active;
        public string last_login;
        public string last_name;
        public string newsletter;
        public string phone;
        public string pref_alert_email;
        public string pref_alert_mobile;
        public string pref_alert_sms;
        public bool pref_app_device_id;
        public string pref_balance_email;
        public string pref_referral_code;
        public string pref_subscription_expires;
        public string pref_trade_email;
        public string pref_trade_mobile;
        public string pref_trade_sms;
        public string referral_balance;
        public string state;
        public string street1;
        public string street2;
        public string subscription_status;
        public string ticker_enabled;
        public string ticker_indicator_time_type;
        public string two_factor;
        public string zip;
    }
}