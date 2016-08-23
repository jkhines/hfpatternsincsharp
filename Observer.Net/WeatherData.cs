using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherOMatic.Net
{
    struct WeatherMeasurements
    {
        public float temperature;
        public float humidity;
        public float pressure;
    }
    
    class WeatherData
    {
        private WeatherMeasurements readings = new WeatherMeasurements();
        public delegate void ChangeHandler(object sender, WeatherMeasurements newReadings);
        public event ChangeHandler ChangeEvent;

        public void Change()
        {
            Notify();
        }

        public void UpdateReadings(WeatherMeasurements newReadings)
        {
            this.readings = newReadings;
            Change();
        }

        private void Notify()
        {
            if (ChangeEvent != null)
                ChangeEvent(this, this.readings);
        }
    }
}
