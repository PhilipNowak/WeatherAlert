using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using WeatherWatch.Core.Events;
using WeatherWatch.Core.Interfaces;
using WeatherWatch.Data.Client;
using WeatherWatch.Domain;
using WeatherWatch.Domain.Dispatcher;
using WeatherWatch.Domain.EventHandlers;

namespace WeatherWatch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AsyncMain().GetAwaiter().GetResult();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        //Running c# 7 so there is no async main
        static async Task AsyncMain()
        {
            //using Microsoft.Extensions.DependencyInjection for DI
            ServiceProvider serviceProvider = new ServiceCollection()
                //Create a new WeatherDataClient evrey time its called.
                .AddTransient<IWeatherDataConsumer, WeatherDataClient>()
                .AddTransient<IHandle<WeatherDataConsumedEvent>, RainAlertHandler>()
                .AddTransient<IHandle<WeatherDataConsumedEvent>, HighTemperatureAlertHandler>()
                .AddTransient<IHandle<WeatherDataConsumedEvent>, LowTemperatureAlertHandler>()
                //Only will Create one WeatherAlter
                .AddSingleton<IWeatherAlerter, WeatherAlerter>()
                .AddSingleton<IDomainEventDispatcher, DomainEventDispatcher>()
                .BuildServiceProvider();

            IWeatherAlerter weatherAlerter = serviceProvider.GetService<IWeatherAlerter>();
            await weatherAlerter.AlertAsync();

        }
    }
}
