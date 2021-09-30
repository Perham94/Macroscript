using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApplication1
{
    internal class Program
    {
        
        [DllImport("user32.dll")]
        public static extern int FindWindow(
            string lpClassName, // class name 
            string lpWindowName // window name 
        );

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(
            int hWnd // handle to window
        );



        public static void SendKeys()
        {
            
            int iHandle = FindWindow(null, "New World");
            SetForegroundWindow(iHandle);
           
          

      
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key != ConsoleKey.Escape))
            {
                if (DateTime.Now.Hour >= 21)
                {
                    break;
                }
                
        
                    Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_TAB, false, Keyboard.InputType.Keyboard);
                    Thread.Sleep(500);

            } 
        }
        
        
        public static void Main(string[] args)
        
        {
            SendKeys();

        }
    }
}