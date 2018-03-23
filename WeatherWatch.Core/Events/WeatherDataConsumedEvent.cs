using System;
using System.Collections.Generic;
using System.Text;
using WeatherWatch.Core.Entities;
using WeatherWatch.Core.Interfaces;

namespace WeatherWatch.Core.Events
{
    public class WeatherDataConsumedEvent : IDomainEvent
    {
        public WeatherDataConsumedEvent(Channel channel)
        {
            Channel = channel;
        }

        public Channel Channel { get; private set; }
    }
}
