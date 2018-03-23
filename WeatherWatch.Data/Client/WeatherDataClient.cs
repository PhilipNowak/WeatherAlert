using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherWatch.Core.Entities;
using WeatherWatch.Core.Interfaces;

namespace WeatherWatch.Data.Client
{
    public class WeatherDataClient : IWeatherDataConsumer
    {
        private static readonly string _url = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20weather.forecast%20where%20woeid%20in%20%28select%20woeid%20from%20geo.places%281%29%20where%20text%3D%22Chicago%22%29&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

        public async Task<Channel> ConsumeAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(_url);
            response.EnsureSuccessStatusCode();
            RootObject rootResult = JsonConvert.DeserializeObject<RootObject>(await response.Content.ReadAsStringAsync());

            return rootResult?.query?.Results?.Channel;
        }
    }
}
