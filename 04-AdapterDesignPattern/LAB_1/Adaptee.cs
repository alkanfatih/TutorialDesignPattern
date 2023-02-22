using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_AdapterDesignPattern.LAB_1
{
    public class Adaptee
    {
        //Windows form üyesi olan MessageBox'ı adapte ediyoruz.

        [DllImport("user32.dll", EntryPoint = "MessageBox", CallingConvention = CallingConvention.Winapi)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint buttons);
        public void alert(string title, string message, Buttons combination)
        { 
            MessageBox(new IntPtr(), message, title, (uint)combination);
        }
    }
}
