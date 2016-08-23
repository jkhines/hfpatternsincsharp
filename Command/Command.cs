using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class NoCommand : ICommand
    {
        #region ICommand Members

        public void Execute()
        {
        }

        #endregion
    }

    public class LightOn : ICommand
    {
        Light light;

        public LightOn(Light light)
        {
            this.light = light;
        }

        #region ICommand Members
        public void Execute()
        {
            this.light.On();
        }

        #endregion
    }

    public class GarageDoorOpen : ICommand
    {
        GarageDoor door;

        public GarageDoorOpen(GarageDoor door)
        {
            this.door = door;
        }

        #region ICommand Members
        public void Execute()
        {
            this.door.LightOn();
            this.door.Up();
        }

        #endregion
    }
    public class LightOff : ICommand
    {
        Light light;

        public LightOff(Light light)
        {
            this.light = light;
        }

        #region ICommand Members
        public void Execute()
        {
            this.light.Off();
        }

        #endregion
    }

    public class GarageDoorClose : ICommand
    {
        GarageDoor door;

        public GarageDoorClose(GarageDoor door)
        {
            this.door = door;
        }

        #region ICommand Members
        public void Execute()
        {
            this.door.Down();
            this.door.LightOff();
        }

        #endregion
    }
}
