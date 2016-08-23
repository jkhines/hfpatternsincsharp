using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherOMatic_Explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the subject and observers
            WeatherData weatherData = new WeatherData();

            CurrentConditions conditions = new CurrentConditions(weatherData);
            Statistics statistics = new Statistics(weatherData);
            Forecast forecast = new Forecast(weatherData);

            // create the readings
            WeatherMeasurements readings = new WeatherMeasurements();
            readings.humidity = 40.5F;
            readings.pressure = 20F;
            readings.temperature = 72F;

            // update the readings - everyone should print
            weatherData.UpdateReadings(readings);

            // update
            readings.pressure = 10F;
            weatherData.UpdateReadings(readings);

            // update
            readings.humidity = 100;
            readings.temperature = 212.75F;
            readings.pressure = 950;
            weatherData.UpdateReadings(readings);

            Console.ReadLine();
        }
    }
}
