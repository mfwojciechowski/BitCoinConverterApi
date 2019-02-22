using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;


namespace BitCoinConverterApi
{
    static class ApiConnection
    {
        private static string path = "https://api.coindesk.com/v1/bpi/currentprice/PLN.json";

        private static HttpClient client = new HttpClient();

        public static async Task<BitCoinData> getActualRate()
        {
            BitCoinData data = null;
            HttpResponseMessage respone = await client.GetAsync(path);

            if (respone.IsSuccessStatusCode)
            {
                string responseString = await respone.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<BitCoinData>(responseString);
            }

            return data;
        }
    }
}
