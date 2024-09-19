using System;
using System.Runtime.InteropServices;

namespace MouseMoveByKey {
    public class MouseHelper {

        private const uint MOUSEEVENTF_MOVE = 0x0001;
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private static int _moveFactor = 2;
        public static bool lButtonCurrentlyPressed = false;
        public static bool rButtonCurrentlyPressed = false;

        public static void MouseEventHandler(MouseEvent mouseEvent, int magnitude) {
            switch(mouseEvent) {
                case MouseEvent.Left:
                    mouse_event(MOUSEEVENTF_MOVE, -1 * _moveFactor * magnitude, 0, 0, (UIntPtr)0);
                    return;
                case MouseEvent.Right:
                    mouse_event(MOUSEEVENTF_MOVE, 1 * _moveFactor * magnitude, 0, 0, (UIntPtr)0);
                    return;
                case MouseEvent.Up:
                    mouse_event(MOUSEEVENTF_MOVE, 0, -1 * _moveFactor * magnitude, 0, (UIntPtr)0);
                    return;
                case MouseEvent.Down:
                    mouse_event(MOUSEEVENTF_MOVE, 0, 1 * _moveFactor * magnitude, 0, (UIntPtr)0);
                    return;
                case MouseEvent.LButton:
                    if (lButtonCurrentlyPressed == false) {
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, (UIntPtr)0);
                    }
                    else {
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, (UIntPtr)0);
                    }
                    lButtonCurrentlyPressed = !lButtonCurrentlyPressed;
                    return;
                case MouseEvent.RButton:
                    if (rButtonCurrentlyPressed == false) {
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, (UIntPtr)0);
                    }
                    else {
                        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, (UIntPtr)0);
                    }
                    rButtonCurrentlyPressed = !rButtonCurrentlyPressed;
                    return;
            }
        }
        
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);
    }
}
