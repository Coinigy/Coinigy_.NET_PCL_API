//https://lisk.io/documentation?i=lisk-docs/APIReference
//Author: Allen Byron Penner
//TODO: fix the way errors are handled in http methods
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Coinigy.API.Responses;
using Newtonsoft.Json;

namespace Coinigy.API
{
    public class CoinigyApi
    {
        public string User_Agent { get; set; }
        public string Server_Url { get; set; }

        private string Api_Key { get; set; }

        private string Api_Secret { get; set; }

        public CoinigyApi(string api_key, string api_secret, string serverBaseUrl = "https://www.coinigy.com/api/v1/",
            string userAgent =
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36")
        {
            User_Agent = userAgent;
            Server_Url = serverBaseUrl;
            Api_Key = api_key;
            Api_Secret = api_secret;
        }

        public userInfo_response UserInfo()
        {
            var url = "userInfo";
            var gr = HttpPostRequest(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<userInfo_response>(gr);
        }

        public async Task<userInfo_response> UserInfoAsync()
        {
            var url = "userInfo";
            var gr = await HttpPostRequestAsync(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<userInfo_response>(gr);
        }

        public activity_response Activity()
        {
            var url = "activity";
            var gr = HttpPostRequest(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<activity_response>(gr);
        }

        public async Task<activity_response> ActivityAsync()
        {
            var url = "activity";
            var gr = await HttpPostRequestAsync(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<activity_response>(gr);
        }

        public accounts_response Accounts()
        {
            var url = "accounts";
            var gr = HttpPostRequest(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<accounts_response>(gr);
        }

        public async Task<accounts_response> AccountsAsync()
        {
            var url = "accounts";
            var gr = await HttpPostRequestAsync(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<accounts_response>(gr);
        }

        public balances_response Balances(bool show_nils = false, string auth_ids = "")
        {
            var url = "balances";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("show_nils", Convert.ToInt32(show_nils).ToString()),
                new KeyValuePair<string, string>("auth_ids", auth_ids)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<balances_response>(gr);
        }

        public async Task<balances_response> BalancesAsync(bool show_nils = false, string auth_ids = "")
        {
            var url = "balances";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("show_nils", Convert.ToInt32(show_nils).ToString()),
                new KeyValuePair<string, string>("auth_ids", auth_ids)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<balances_response>(gr);
        }

        public balanceHistory_response BalanceHistory(string date = "")
        {
            if (String.IsNullOrEmpty(date))
                date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            var url = "balanceHistory";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("date", date)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<balanceHistory_response>(gr);
        }

        public async Task<balanceHistory_response> BalanceHistoryAsync(string date = "")
        {
            if (String.IsNullOrEmpty(date))
                date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            var url = "balanceHistory";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("date", date)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<balanceHistory_response>(gr);
        }

        public orders_response Orders()
        {
            var url = "orders";
            var gr = HttpPostRequest(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<orders_response>(gr);
        }

        public async Task<orders_response> OrdersAsync()
        {
            var url = "orders";
            var gr = await HttpPostRequestAsync(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<orders_response>(gr);
        }

        public alerts_response Alerts()
        {
            var url = "alerts";
            var gr = HttpPostRequest(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<alerts_response>(gr);
        }

        public async Task<alerts_response> AlertsAsync()
        {
            var url = "alerts";
            var gr = await HttpPostRequestAsync(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<alerts_response>(gr);
        }

        public userWatchList_response UserWatchList()
        {
            var url = "userWatchList";
            var gr = HttpPostRequest(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<userWatchList_response>(gr);
        }

        public async Task<userWatchList_response> UserWatchListAsync()
        {
            var url = "userWatchList";
            var gr = await HttpPostRequestAsync(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<userWatchList_response>(gr);
        }

        public newsFeed_response NewsFeed()
        {
            var url = "newsFeed";
            var gr = HttpPostRequest(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<newsFeed_response>(gr);
        }

        public async Task<newsFeed_response> NewsFeedAsync()
        {
            var url = "newsFeed";
            var gr = await HttpPostRequestAsync(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<newsFeed_response>(gr);
        }

        public updateUser_response UpdateUser(string first_name, string last_name, string company, string phone, string street1, string street2, string city, string state, string zip, string country)
        {
            var url = "updateUser";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("first_name", first_name),
                new KeyValuePair<string, string>("last_name", last_name),
                new KeyValuePair<string, string>("last_name", company),
                new KeyValuePair<string, string>("last_name", phone),
                new KeyValuePair<string, string>("last_name", street1),
                new KeyValuePair<string, string>("last_name", street2),
                new KeyValuePair<string, string>("last_name", city),
                new KeyValuePair<string, string>("last_name", state),
                new KeyValuePair<string, string>("last_name", zip),
                new KeyValuePair<string, string>("last_name", country)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<updateUser_response>(gr);
        }

        public async Task<updateUser_response> UpdateUserAsync(string first_name, string last_name, string company, string phone, string street1, string street2, string city, string state, string zip, string country)
        {
            var url = "updateUser";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("first_name", first_name),
                new KeyValuePair<string, string>("last_name", last_name),
                new KeyValuePair<string, string>("last_name", company),
                new KeyValuePair<string, string>("last_name", phone),
                new KeyValuePair<string, string>("last_name", street1),
                new KeyValuePair<string, string>("last_name", street2),
                new KeyValuePair<string, string>("last_name", city),
                new KeyValuePair<string, string>("last_name", state),
                new KeyValuePair<string, string>("last_name", zip),
                new KeyValuePair<string, string>("last_name", country)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<updateUser_response>(gr);
        }

        public updatePrefs_response UpdatePrefs(bool alert_email, bool alert_sms, bool trade_email, bool trade_sms, bool balance_email)
        {
            var url = "updatePrefs";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("alert_email", Convert.ToInt32(alert_email).ToString()),
                new KeyValuePair<string, string>("last_name", Convert.ToInt32(alert_sms).ToString()),
                new KeyValuePair<string, string>("last_name", Convert.ToInt32(trade_email).ToString()),
                new KeyValuePair<string, string>("last_name", Convert.ToInt32(trade_sms).ToString()),
                new KeyValuePair<string, string>("last_name", Convert.ToInt32(balance_email).ToString())
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<updatePrefs_response>(gr);
        }

        public async Task<updatePrefs_response> UpdatePrefsAsync(bool alert_email, bool alert_sms, bool trade_email, bool trade_sms, bool balance_email)
        {
            var url = "updatePrefs";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("alert_email", Convert.ToInt32(alert_email).ToString()),
                new KeyValuePair<string, string>("last_name", Convert.ToInt32(alert_sms).ToString()),
                new KeyValuePair<string, string>("last_name", Convert.ToInt32(trade_email).ToString()),
                new KeyValuePair<string, string>("last_name", Convert.ToInt32(trade_sms).ToString()),
                new KeyValuePair<string, string>("last_name", Convert.ToInt32(balance_email).ToString())
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<updatePrefs_response>(gr);
        }

        public updateTickers_response UpdateTickers(string exch_mkt_ids)
        {
            var url = "updateTickers";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("exch_mkt_ids", exch_mkt_ids)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<updateTickers_response>(gr);
        }

        public async Task<updateTickers_response> UpdateTickersAsync(string exch_mkt_ids)
        {
            var url = "updateTickers";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("exch_mkt_ids", exch_mkt_ids)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<updateTickers_response>(gr);
        }

        public orderTypes_response OrderTypes()
        {
            var url = "orderTypes";
            var gr = HttpPostRequest(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<orderTypes_response>(gr);
        }

        public async Task<orderTypes_response> OrderTypesAsync()
        {
            var url = "orderTypes";
            var gr = await HttpPostRequestAsync(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<orderTypes_response>(gr);
        }

        public refreshBalance_response RefreshBalance(string auth_id)
        {
            var url = "refreshBalance";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("auth_id", auth_id)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<refreshBalance_response>(gr);
        }

        public async Task<refreshBalance_response> RefreshBalanceAsync(string auth_id)
        {
            var url = "refreshBalance";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("auth_id", auth_id)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<refreshBalance_response>(gr);
        }

        public addAlert_response AddAlert(string exch_code, string market_name, string alert_price, string alert_note = "")
        {
            var url = "addAlert";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("exch_code", exch_code),
                new KeyValuePair<string, string>("market_name", market_name),
                new KeyValuePair<string, string>("alert_price", alert_price),
                new KeyValuePair<string, string>("alert_note", alert_note)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<addAlert_response>(gr);
        }

        public async Task<addAlert_response> AddAlertAsync(string exch_code, string market_name, string alert_price, string alert_note = "")
        {
            var url = "addAlert";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("exch_code", exch_code),
                new KeyValuePair<string, string>("market_name", market_name),
                new KeyValuePair<string, string>("alert_price", alert_price),
                new KeyValuePair<string, string>("alert_note", alert_note)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<addAlert_response>(gr);
        }

        private string HttpPostRequest(string url, string ua, List<KeyValuePair<string, string>> postdata)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", ua);
            client.DefaultRequestHeaders.Add("X-API-KEY", Api_Key);
            client.DefaultRequestHeaders.Add("X-API-SECRET", Api_Secret);

            var content = new FormUrlEncodedContent(postdata);

            var response = client.PostAsync(Server_Url + url, content).Result;

            return response.IsSuccessStatusCode
                ? response.Content.ReadAsStringAsync().Result
                : "ERROR:" + response.StatusCode + " " + response.ReasonPhrase + " | " + response.RequestMessage;
        }

        private async Task<string> HttpPostRequestAsync(string url, string ua, List<KeyValuePair<string, string>> postdata)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", ua);
            client.DefaultRequestHeaders.Add("X-API-KEY", Api_Key);
            client.DefaultRequestHeaders.Add("X-API-SECRET", Api_Secret);

            var content = new FormUrlEncodedContent(postdata);

            var response = await client.PostAsync(Server_Url + url, content);

            return response.IsSuccessStatusCode
                ? await response.Content.ReadAsStringAsync()
                : "ERROR:" + response.StatusCode + " " + response.ReasonPhrase + " | " + response.RequestMessage;
        }
    }
}
