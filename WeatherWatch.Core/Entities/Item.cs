using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherWatch.Core.Entities
{
    public class Item
    {
        public string Title { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string Link { get; set; }
        public string PubDate { get; set; }
        public Condition Condition { get; set; }
        public IList<Forecast> Forecast { get; set; }
        public string Description { get; set; }
        public Guid Guid { get; set; }
    }
}
