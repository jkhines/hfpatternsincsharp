using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Command
{
    public class Light
    {
        public void On()
        {
            Util.DisplayCurrentMethodName();
        }

        public void Off()
        {
            Util.DisplayCurrentMethodName();
        }
    }

    public class GarageDoor
    {
        public void Up()
        {
            Util.DisplayCurrentMethodName();
        }

        public void Down()
        {
            Util.DisplayCurrentMethodName();
        }

        public void Stop()
        {
            Util.DisplayCurrentMethodName();
        }

        public void LightOn()
        {
            Util.DisplayCurrentMethodName();
        }

        public void LightOff()
        {
            Util.DisplayCurrentMethodName();
        }

    }

    static class Util
    {
        public static void DisplayCurrentMethodName()
        {
            StackTrace stackTrace = new StackTrace();

            Console.WriteLine("{0} - {1}",
                stackTrace.GetFrame(0).GetType().Name,
                stackTrace.GetFrame(1).GetMethod().Name);
        }
    }
}
