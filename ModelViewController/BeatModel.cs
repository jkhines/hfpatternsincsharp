using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ModelViewController 
{
    class BeatModel: IBeatModel
    {
        // Sequencer sequencer;
        private ArrayList beatObservers = new ArrayList();
        private ArrayList bpmObservers = new ArrayList();
        //private int bpm = 90;

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void On()
        {
            throw new NotImplementedException();
        }

        public void Off()
        {
            throw new NotImplementedException();
        }

        public void setBpm()
        {
            throw new NotImplementedException();
        }

        public void getBpm()
        {
            throw new NotImplementedException();
        }

        #region Observer Pattern Methods
        #endregion

        #region Midi Generation Methods via NAudio 1.3
        #endregion
    }
}
