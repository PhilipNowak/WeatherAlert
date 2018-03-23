using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherWatch.Core.Entities;
using WeatherWatch.Core.Events;
using WeatherWatch.Core.Interfaces;

namespace WeatherWatch.Domain.EventHandlers
{
    public class LowTemperatureAlertHandler : IHandle<WeatherDataConsumedEvent>
    {
        private static readonly string _alertMessage = "{0} {1} Low Temperature";

        public void Handle(WeatherDataConsumedEvent domianEvent)
        {
            IEnumerable<Forecast> coldForecasts = domianEvent.Channel.Item.Forecast.Where(x => Int32.Parse(x.Low) < 32);

            foreach (Forecast forecast in coldForecasts)
            {
                Console.WriteLine(String.Format(_alertMessage, forecast.Day, forecast.Date));
            }
        }
    }
}
