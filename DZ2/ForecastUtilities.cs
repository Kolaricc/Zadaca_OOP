using System;
using System.Globalization;

namespace weatherLibrary
{
    public class ForecastUtilities
    {
        public static DailyForecast Parse(string mainstring)
        {
            string[] splitstring = mainstring.Split(',');
            Weather weather = new Weather(Convert.ToDouble(splitstring[1], CultureInfo.InvariantCulture), Convert.ToDouble(splitstring[3], CultureInfo.InvariantCulture), Convert.ToDouble(splitstring[2], CultureInfo.InvariantCulture));
            DailyForecast dailyForecast = new DailyForecast(DateTime.ParseExact(splitstring[0], "dd/M/yyyy hh:mm:ss", CultureInfo.InvariantCulture), weather);
            return dailyForecast;
        }

        public static Weather FindWeatherWithLargestWindchill(Weather[] weathers)
        {
            double largestWindchill = 0;
            int index = 0;
            for (int i = 0; i < weathers.Length; i++)
            {
                if (weathers[i].CalculateWindChill() > largestWindchill)
                {
                    largestWindchill = weathers[i].CalculateWindChill();
                    index = i;
                }
            }
            return weathers[index];
        }
    }
}
