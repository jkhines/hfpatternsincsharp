using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherOMatic_Explicit
{
    interface ISubject
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
        void Notify();
    }

    interface IObserver
    {
        void Update(WeatherMeasurements newReadings);
    }

    interface IDisplay
    {
        void Display();
    }
}
