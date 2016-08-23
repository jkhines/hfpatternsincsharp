using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            LightOn lightOn = new LightOn(light);
            LightOff lightOff = new LightOff(light);

            remote.SetCommand(0, lightOn, lightOff);
            remote.OnButtonWasPressed(0);
            remote.OffButtonWasPressed(0);

            GarageDoor door = new GarageDoor();
            GarageDoorOpen doorOpen = new GarageDoorOpen(door);
            GarageDoorClose doorClose = new GarageDoorClose(door);

            remote.SetCommand(1, doorOpen, doorClose);
            remote.OnButtonWasPressed(1);
            remote.OffButtonWasPressed(1);
        }
    }

    public class SimpleRemoteControl
    {
        public const int APP_COUNT = 7;

        // we are modeling a remote control where
        // one button push equals activating a device and
        // another button push equals deactivating the device.
        ICommand[] onCommands;
        ICommand[] offCommands;

        public SimpleRemoteControl()
        {
            onCommands = new ICommand[APP_COUNT];
            offCommands = new ICommand[APP_COUNT];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i != APP_COUNT; ++i)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            this.onCommands[slot] = onCommand;
            this.offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            this.onCommands[slot].Execute();
        }

        public void OffButtonWasPressed(int slot)
        {
            this.offCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder("\n--- Remote Control ---\n");
            for (int i = 0; i != this.onCommands.Length; ++i)
                output.AppendFormat("[slot {0}] {1} {2}\n",
                    i, this.onCommands[i].GetType().Name, this.offCommands[i].GetType().Name);
            return output.ToString();
        }
    }
}
