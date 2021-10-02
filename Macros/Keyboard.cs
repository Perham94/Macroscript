using System;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace ConsoleApplication1
{
    internal class Keyboard
    {
        private static int i { get; set; }

        [DllImport("user32.dll")]
        public static extern int FindWindow(
            string lpClassName,
            string lpWindowName
        );

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(
            int hWnd
        );

        public static void SendKeys(InputSimulator input)
        {
            int iHandle = FindWindow(null, "New World");
            SetForegroundWindow(iHandle);


            do
            {
                Random rnd = new Random();
                i = rnd.Next(0, 3);
                input.Keyboard.KeyDown(GetKey(i));
                Thread.Sleep(500);
                input.Keyboard.KeyUp(GetKey(i));
                // input.Mouse.LeftButtonClick();Thread.Sleep(500);

                input.Keyboard.KeyUp(VirtualKeyCode.VK_W);
            } while (!input.InputDeviceState.IsKeyDown(VirtualKeyCode.ESCAPE));
        }


        public static VirtualKeyCode GetKey(int Index)
        {
            var list = new[] {VirtualKeyCode.VK_A, VirtualKeyCode.VK_D, VirtualKeyCode.VK_S, VirtualKeyCode.VK_W};
            return list[Index];
        }
    }
}