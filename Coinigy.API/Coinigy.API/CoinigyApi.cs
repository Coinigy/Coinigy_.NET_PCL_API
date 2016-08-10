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
        public CoinigyApi(string api_key, string api_secret, string serverBaseUrl = "https://www.coinigy.com/api/v1/",
            string userAgent =
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36")
        {
            User_Agent = userAgent;
            Server_Url = serverBaseUrl;
            Api_Key = api_key;
            Api_Secret = api_secret;
        }

        public string User_Agent { get; set; }
        public string Server_Url { get; set; }

        private string Api_Key { get; }

        private string Api_Secret { get; }

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
            if (string.IsNullOrEmpty(date))
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
            if (string.IsNullOrEmpty(date))
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

        public updateUser_response UpdateUser(string first_name, string last_name, string company, string phone,
            string street1, string street2, string city, string state, string zip, string country)
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

        public async Task<updateUser_response> UpdateUserAsync(string first_name, string last_name, string company,
            string phone, string street1, string street2, string city, string state, string zip, string country)
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

        public updatePrefs_response UpdatePrefs(bool alert_email, bool alert_sms, bool trade_email, bool trade_sms,
            bool balance_email)
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

        public async Task<updatePrefs_response> UpdatePrefsAsync(bool alert_email, bool alert_sms, bool trade_email,
            bool trade_sms, bool balance_email)
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

        public addAlert_response AddAlert(string exch_code, string market_name, string alert_price,
            string alert_note = "")
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

        public async Task<addAlert_response> AddAlertAsync(string exch_code, string market_name, string alert_price,
            string alert_note = "")
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

        public deleteAlert_response DeleteAlert(string alert_id)
        {
            var url = "deleteAlert";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("alert_id", alert_id)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<deleteAlert_response>(gr);
        }

        public async Task<deleteAlert_response> DeleteAlertAsync(string alert_id)
        {
            var url = "deleteAlert";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("alert_id", alert_id)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<deleteAlert_response>(gr);
        }

        public addApiKey_response AddApiKey(string api_key, string api_secret, string api_exch_id, string api_nickname)
        {
            var url = "addApiKey";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("api_key", api_key),
                new KeyValuePair<string, string>("api_secret", api_secret),
                new KeyValuePair<string, string>("api_exch_id", api_exch_id),
                new KeyValuePair<string, string>("api_nickname", api_nickname)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<addApiKey_response>(gr);
        }

        public async Task<addApiKey_response> AddApiKeyAsync(string api_key, string api_secret, string api_exch_id,
            string api_nickname)
        {
            var url = "addApiKey";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("api_key", api_key),
                new KeyValuePair<string, string>("api_secret", api_secret),
                new KeyValuePair<string, string>("api_exch_id", api_exch_id),
                new KeyValuePair<string, string>("api_nickname", api_nickname)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<addApiKey_response>(gr);
        }

        public deleteApiKey_response DeleteApiKey(string auth_id)
        {
            var url = "deleteApiKey";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("auth_id", auth_id)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<deleteApiKey_response>(gr);
        }

        public async Task<deleteApiKey_response> DeleteApiKeyAsync(string auth_id)
        {
            var url = "deleteApiKey";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("auth_id", auth_id)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<deleteApiKey_response>(gr);
        }

        public activateApiKey_response ActivateApiKey(string auth_id, bool auth_active = true)
        {
            var url = "activateApiKey";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("auth_id", auth_id),
                new KeyValuePair<string, string>("auth_active", Convert.ToInt32(auth_id).ToString())
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<activateApiKey_response>(gr);
        }

        public async Task<activateApiKey_response> ActivateApiKeyAsync(string auth_id, bool auth_active = true)
        {
            var url = "activateApiKey";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("auth_id", auth_id),
                new KeyValuePair<string, string>("auth_active", Convert.ToInt32(auth_id).ToString())
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<activateApiKey_response>(gr);
        }

        public activateTradingKey_response ActivateTradingKey(string auth_id, bool auth_trade = true)
        {
            var url = "activateTradingKey";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("auth_id", auth_id),
                new KeyValuePair<string, string>("auth_trade", Convert.ToInt32(auth_id).ToString())
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<activateTradingKey_response>(gr);
        }

        public async Task<activateTradingKey_response> ActivateTradingKeyAsync(string auth_id, bool auth_trade = true)
        {
            var url = "activateTradingKey";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("auth_id", auth_id),
                new KeyValuePair<string, string>("auth_trade", Convert.ToInt32(auth_id).ToString())
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<activateTradingKey_response>(gr);
        }

        public addOrder_response AddOrder(int auth_id, int exch_id, int mkt_id, int order_type_id, int price_type_id,
            decimal limit_price, decimal order_quantity)
        {
            var url = "addOrder";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("auth_id", auth_id.ToString()),
                new KeyValuePair<string, string>("exch_id", exch_id.ToString()),
                new KeyValuePair<string, string>("mkt_id", mkt_id.ToString()),
                new KeyValuePair<string, string>("order_type_id", order_type_id.ToString()),
                new KeyValuePair<string, string>("price_type_id", price_type_id.ToString()),
                new KeyValuePair<string, string>("limit_price", limit_price.ToString()),
                new KeyValuePair<string, string>("order_quantity", order_quantity.ToString())
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<addOrder_response>(gr);
        }

        public async Task<addOrder_response> AddOrderAsync(int auth_id, int exch_id, int mkt_id, int order_type_id,
            int price_type_id, decimal limit_price, decimal order_quantity)
        {
            var url = "addOrder";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("auth_id", auth_id.ToString()),
                new KeyValuePair<string, string>("exch_id", exch_id.ToString()),
                new KeyValuePair<string, string>("mkt_id", mkt_id.ToString()),
                new KeyValuePair<string, string>("order_type_id", order_type_id.ToString()),
                new KeyValuePair<string, string>("price_type_id", price_type_id.ToString()),
                new KeyValuePair<string, string>("limit_price", limit_price.ToString()),
                new KeyValuePair<string, string>("order_quantity", order_quantity.ToString())
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<addOrder_response>(gr);
        }

        public cancelOrder_response CancelOrder(int internal_order_id)
        {
            var url = "cancelOrder";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("internal_order_id", internal_order_id.ToString())
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<cancelOrder_response>(gr);
        }

        public async Task<cancelOrder_response> CancelOrderAsync(int internal_order_id)
        {
            var url = "cancelOrder";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("internal_order_id", internal_order_id.ToString())
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<cancelOrder_response>(gr);
        }

        public exchanges_response Exchanges()
        {
            var url = "exchanges";
            var gr = HttpPostRequest(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<exchanges_response>(gr);
        }

        public async Task<exchanges_response> ExchangesAsync()
        {
            var url = "exchanges";
            var gr = await HttpPostRequestAsync(url, User_Agent, new List<KeyValuePair<string, string>>());
            return JsonConvert.DeserializeObject<exchanges_response>(gr);
        }

        public markets_response Markets(string exchange_code)
        {
            var url = "markets";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("exchange_code", exchange_code)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<markets_response>(gr);
        }

        public async Task<markets_response> MarketsAsync(string exchange_code)
        {
            var url = "markets";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("exchange_code", exchange_code)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<markets_response>(gr);
        }

        public data_response Data(string exchange_code, string exchange_market, MarketDataType type)
        {
            var url = "data";
            var typename = Enum.GetName(typeof(MarketDataType), type);
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("exchange_code", exchange_code),
                new KeyValuePair<string, string>("exchange_market", exchange_market),
                new KeyValuePair<string, string>("type", typename)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<data_response>(gr);
        }

        public async Task<data_response> DataAsync(string exchange_code, string exchange_market, MarketDataType type)
        {
            var url = "data";
            var typename = Enum.GetName(typeof(MarketDataType), type);
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("exchange_code", exchange_code),
                new KeyValuePair<string, string>("exchange_market", exchange_market),
                new KeyValuePair<string, string>("type", typename)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<data_response>(gr);
        }

        public ticker_response Ticker(string exchange_code, string exchange_market)
        {
            var url = "ticker";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("exchange_code", exchange_code),
                new KeyValuePair<string, string>("exchange_market", exchange_market)
            };
            var gr = HttpPostRequest(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<ticker_response>(gr);
        }

        public async Task<ticker_response> TickerAsync(string exchange_code, string exchange_market)
        {
            var url = "ticker";
            var pd = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("exchange_code", exchange_code),
                new KeyValuePair<string, string>("exchange_market", exchange_market)
            };
            var gr = await HttpPostRequestAsync(url, User_Agent, pd);
            return JsonConvert.DeserializeObject<ticker_response>(gr);
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

        private async Task<string> HttpPostRequestAsync(string url, string ua,
            List<KeyValuePair<string, string>> postdata)
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