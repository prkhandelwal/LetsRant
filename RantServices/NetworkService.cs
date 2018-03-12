using Newtonsoft.Json;
using RantServices.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RantServices
{
    public class NetworkService
    {
        private const string api = "http://127.0.0.1:5000/";

        private static System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
        private static System.Net.Http.HttpResponseMessage httpResponse = new System.Net.Http.HttpResponseMessage();

        public async static Task<RecData> GetData()
        {
            string httpResponseBody = "";
            try
            {
                string uri = String.Format(api);
                httpResponse = await httpClient.GetAsync(new Uri(uri));
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
                RecData data = JsonConvert.DeserializeObject<RecData>(httpResponseBody);
                return data;
            }
            catch (Exception e)
            {

                RecData ErrorData = new RecData
                {
                    data = null
                };
                return ErrorData;
            }
        }
    }
}
