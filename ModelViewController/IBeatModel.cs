using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelViewController
{
    interface IBeatModel
    {
        void Initialize();
        void On();
        void Off();
        void setBpm();
        void getBpm();

        // observer pattern methods
        //void registerObserver(BeatObserver observer);
        //void removeObserver(BeatObserver observer);
        //void registerObserver(BpmObserver observer);
        //void removeObserver(BpmObserver observer);
    }
}
