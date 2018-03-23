using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWatch.Core.Interfaces
{
    public interface IWeatherAlerter
    {
        Task AlertAsync();
    }
}
