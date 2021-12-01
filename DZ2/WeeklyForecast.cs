using System;
using System.Text;

namespace weatherLibrary
{
    public class WeeklyForecast
    {
        private DailyForecast[] dailyForecasts;
        public WeeklyForecast(DailyForecast[] dailyForecasts)
        {
            this.dailyForecasts = dailyForecasts;
        }
        public string GetAsString()
        {
            StringBuilder str  = new StringBuilder();
            foreach (DailyForecast dailyForecast in dailyForecasts)
            {
                str.Append(dailyForecast.GetAsString()+"\n");
            }
            return str.ToString();
        }
        public string GetMaxTemperature()
        {
            DailyForecast MaxTemperature = dailyForecasts[0];
            foreach (DailyForecast dailyForecast in dailyForecasts)
            {
                if (MaxTemperature < dailyForecast)
                {
                    MaxTemperature = dailyForecast;
                }
            }
            return MaxTemperature.CurrentWeather.GetTemperature().ToString(System.Globalization.CultureInfo.InvariantCulture);
        }
        public DailyForecast this[int i]
        {
            get
            {
                return dailyForecasts[i];
            }
        }
       
    }
}
