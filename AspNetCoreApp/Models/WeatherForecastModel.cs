using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Models
{
    /*
     * [{"title":"Seoul","location_type":"City","woeid":1132599,"latt_long":"37.557121,126.977379"}]
     * 
     * API Endpoint: https://www.metaweather.com/api/location/1132599/
     */
    public class WeatherForecastModel
    {
        public DayForecastModel[] Consolidated_weather { get; set; }
        public DateTime Sun_rise { get; set; }
        public DateTime Sun_set { get; set; }
        public string Title { get; set; }
        public string Timezone { get; set; }
    }
}
