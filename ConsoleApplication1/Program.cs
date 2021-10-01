using System;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApplication1
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int FindWindow(
            string lpClassName, 
            string lpWindowName 
        );

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(
            int hWnd 
        );

      

        public static void SendKeys()
        {
            
            int iHandle = FindWindow(null, "New World");
            SetForegroundWindow(iHandle);
            
            
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {

         
               
                if (DateTime.Now.Hour >= 24) { break; }
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_A, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(500);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_A, true, Keyboard.InputType.Keyboard);
                Thread.Sleep(500);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_D, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(500);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_D, true, Keyboard.InputType.Keyboard);
                Thread.Sleep(500);
               
                
                
            }
        }

        public static void Main(string[] args) {
            SendKeys();
        }
    }
}