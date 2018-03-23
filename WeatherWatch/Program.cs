using System;
using System.Threading.Tasks;
using WeatherWatch.Data.Client;

namespace WeatherWatch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AsyncMain().GetAwaiter().GetResult();           
        }

        //Running c# 7 so there is no async main
        static async Task AsyncMain()
        {
            WeatherDataClient client = new WeatherDataClient();
            var result =  await client.ConsumeAsync();
        }
    }
}
