using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherWatch.Core.Entities;
using WeatherWatch.Core.Events;
using WeatherWatch.Core.Interfaces;

namespace WeatherWatch.Domain.EventHandlers
{
    public class RainAlertHandler : IHandle<WeatherDataConsumedEvent>
    {
        private static readonly string _alertMessage = "{0} {1} Rain";

        public void Handle(WeatherDataConsumedEvent domianEvent)
        {
            IEnumerable<Forecast> rainyForecasts = domianEvent.Channel.Item.Forecast.Where(x => x.Text.Contains("Showers"));

            foreach(Forecast forecast in rainyForecasts)
            {
                Console.WriteLine(String.Format(_alertMessage, forecast.Day, forecast.Date));
            }
            
        }

    }
}
