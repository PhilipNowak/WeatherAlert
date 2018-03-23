using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherWatch.Core.Entities;
using WeatherWatch.Core.Events;
using WeatherWatch.Core.Interfaces;

namespace WeatherWatch.Domain
{
    public class WeatherAlerter : IWeatherAlerter
    {
        private IWeatherDataConsumer _weatherDataConsumer;
        private IDomainEventDispatcher _eventDispatcher;

        public WeatherAlerter(IWeatherDataConsumer weatherDataConsumer, IDomainEventDispatcher eventDispatcher)
        {
            _weatherDataConsumer = weatherDataConsumer;
            _eventDispatcher = eventDispatcher;
        }

        public async Task AlertAsync()
        {
            Channel channel = await _weatherDataConsumer.ConsumeAsync();

            _eventDispatcher.Dispatch(new WeatherDataConsumedEvent(channel));
        }
    }
}
