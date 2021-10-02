using System;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace ConsoleApplication1
{
    class Entrypoint

    {
        public static void Main(string[] args)
        {
            InputSimulator Input = new InputSimulator();
            Keyboard.SendKeys(Input);
        }
    }
}