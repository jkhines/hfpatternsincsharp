using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherOMatic.Net
{
    class CurrentConditions : IDisplay, IDisposable
    {
        private WeatherData weatherData = null;
        private WeatherMeasurements readings = new WeatherMeasurements();

        public CurrentConditions(WeatherData newWeatherData)
        {
            this.weatherData = newWeatherData;
            this.weatherData.ChangeEvent += new WeatherData.ChangeHandler(Update);
        }

        public void Update(object subject, WeatherMeasurements newReadings)
        {
            if (subject is WeatherData)
            {
                this.readings = newReadings;
                Display();
            }
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: {0}F degrees and {1}% humidity.",
                this.readings.temperature, this.readings.humidity);
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.weatherData.ChangeEvent -= new WeatherData.ChangeHandler(Update);
        }

        #endregion
    }

    class Statistics : IDisplay, IDisposable
    {
        private WeatherData weatherData = null;
        private WeatherMeasurements readings = new WeatherMeasurements();

        public Statistics(WeatherData newWeatherData)
        {
            this.weatherData = newWeatherData;
            this.weatherData.ChangeEvent += new WeatherData.ChangeHandler(Update);
        }

        public void Update(object subject, WeatherMeasurements newReadings)
        {
            if (subject is WeatherData)
            {
                this.readings = newReadings;
                Display();
            }
        }

        public void Display()
        {
            Console.WriteLine("Statistic: Sum of values: {0}.",
                this.readings.temperature + this.readings.humidity + this.readings.pressure);
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.weatherData.ChangeEvent -= new WeatherData.ChangeHandler(Update);
        }

        #endregion
    }

    class Forecast : IDisplay, IDisposable
    {
        private WeatherData weatherData = null;
        private WeatherMeasurements readings = new WeatherMeasurements();

        public Forecast(WeatherData newWeatherData)
        {
            this.weatherData = newWeatherData;
            this.weatherData.ChangeEvent += new WeatherData.ChangeHandler(Update);
        }

        public void Update(object subject, WeatherMeasurements newReadings)
        {
            if (subject is WeatherData)
            {
                this.readings = newReadings;
                Display();
            }
        }

        public void Display()
        {
            Console.WriteLine("Forecast: {0}F degress and {1}% humidity.",
                this.readings.temperature + 13.3,
                this.readings.humidity - 13.3);
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.weatherData.ChangeEvent -= new WeatherData.ChangeHandler(Update);
        }

        #endregion
    }
}
