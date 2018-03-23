using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherWatch.Core.Entities
{
    public class Condition
    {
        public string Code { get; set; }
        public string Date { get; set; }
        public string Temp { get; set; }
        public string Text { get; set; }
    }
}
