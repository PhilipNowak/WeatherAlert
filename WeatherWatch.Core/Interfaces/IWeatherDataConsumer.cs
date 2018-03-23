using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherWatch.Core.Entities;

namespace WeatherWatch.Core.Interfaces
{
    public interface IWeatherDataConsumer
    {
        Task<Channel> ConsumeAsync();
    }
}
