using System;

namespace weatherLibrary
{
    public class DailyForecast
    {
        public Weather CurrentWeather { get; private set; }
        public DateTime date { get; private set; }
        public DailyForecast(DateTime date, Weather CurrentWeather)
        {
            this.date = date;
            this.CurrentWeather = CurrentWeather;
        }
        public string GetAsString()
        {
            return date.ToString("dd/M/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture) + ": " + CurrentWeather.GetAsString();
        }
        public static bool operator >(DailyForecast temp1, DailyForecast temp2)
        {
            return temp1.CurrentWeather.GetTemperature() > temp2.CurrentWeather.GetTemperature();
        }
        public static bool operator <(DailyForecast temp1, DailyForecast temp2)
        {
            return temp1.CurrentWeather.GetTemperature() < temp2.CurrentWeather.GetTemperature();
        }
    }
}
