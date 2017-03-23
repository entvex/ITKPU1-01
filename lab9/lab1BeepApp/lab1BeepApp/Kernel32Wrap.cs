using System.Runtime.InteropServices;

namespace lab1BeepApp
{
    public class Kernel32Wrap
    {
        // http://msdn.microsoft.com/en-us/library/windows/desktop/ms679277(v=vs.85).aspx
        [DllImport("Kernel32", SetLastError = true)]
        public static extern int Beep(uint freq, uint duration);
    }
}