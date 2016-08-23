using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherOMatic_Explicit
{
    class CurrentConditions : IDisplay, IObserver, IDisposable
    {
        private ISubject weatherData = null;
        private WeatherMeasurements readings = new WeatherMeasurements();

        public CurrentConditions(ISubject newWeatherData)
        {
            this.weatherData = newWeatherData;
            this.weatherData.Register(this);
        }

        private void UnRegister()
        {
            if (this.weatherData != null)
                this.weatherData.UnRegister(this);
        }

        #region IDisplay Members

        public void Display()
        {
            Console.WriteLine("Current conditions: {0}F degrees and {1}% humidity.",
                this.readings.temperature, this.readings.humidity);
        }

        #endregion

        #region IObserver Members

        public void Update(WeatherMeasurements newReadings)
        {
            this.readings = newReadings;
            Display();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            this.UnRegister();
        }
        
        #endregion
    }

    class Statistics : IDisplay, IObserver, IDisposable
    {
        private ISubject weatherData = null;
        private WeatherMeasurements readings = new WeatherMeasurements();

        public Statistics(ISubject newWeatherData)
        {
            this.weatherData = newWeatherData;
            this.weatherData.Register(this);
        }

        private void UnRegister()
        {
            if (this.weatherData != null)
                this.weatherData.UnRegister(this);
        }

        #region IDisplay Members

        public void Display()
        {
            Console.WriteLine("Statistic: Sum of values: {0}.",
                this.readings.temperature + this.readings.humidity + this.readings.pressure);
        }

        #endregion

        #region IObserver Members

        public void Update(WeatherMeasurements newReadings)
        {
            this.readings = newReadings;
            Display();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    class Forecast : IDisplay, IObserver, IDisposable
    {
        private ISubject weatherData = null;
        private WeatherMeasurements readings = new WeatherMeasurements();

        public Forecast(ISubject newWeatherData)
        {
            this.weatherData = newWeatherData;
            this.weatherData.Register(this);
        }

        private void UnRegister()
        {
            if (this.weatherData != null)
                this.weatherData.UnRegister(this);
        }

        #region IDisplay Members

        public void Display()
        {
            Console.WriteLine("Forecast: {0}F degress and {1}% humidity.",
                this.readings.temperature + 13.3,
                this.readings.humidity - 13.3);
        }

        #endregion

        #region IObserver Members

        public void Update(WeatherMeasurements newReadings)
        {
            this.readings = newReadings;
            Display();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
