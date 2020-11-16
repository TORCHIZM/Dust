using CSGO_Auto_Accepter.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSGO_Auto_Accepter.Core
{
    internal static class MouseController
    {
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;

        internal static void LeftClick()
        {
            User32.mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(100);
            User32.mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        internal static void MoveAndLeftClick(int x, int y)
        {
            User32.SetCursorPos(x, y);
            LeftClick();
        }
    }
}
