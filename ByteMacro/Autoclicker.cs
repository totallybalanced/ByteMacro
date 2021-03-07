using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ByteMacro
{
    public class Autoclicker
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        //Mouse actions, Global Variables
        private const int LEFTDOWN = 0x0002;
        private const int LEFTUP = 0x0004;

        public static void MouseClick()
        {
            mouse_event(LEFTDOWN , 0, 0, 0, 0);
            mouse_event(LEFTUP, 0, 0, 0, 0);
        }
    }
}
