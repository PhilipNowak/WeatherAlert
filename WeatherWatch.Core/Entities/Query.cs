using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherWatch.Core.Entities
{
    public class Query
    {
        public int Count { get; set; }
        public DateTime Created { get; set; }
        public string Lang { get; set; }
        public Results Results { get; set; }
    }
}
