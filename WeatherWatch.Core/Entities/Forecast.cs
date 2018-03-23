using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherWatch.Core.Entities
{
    public class Forecast
    {
        public string Code { get; set; }
        public string Date { get; set; }
        public string Day { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Text { get; set; }
    }
}
