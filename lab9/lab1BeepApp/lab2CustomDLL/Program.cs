using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab2CustomDLL
{
    class Program
    {
        [DllImport("lab1.1.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddInts(int a, int b);

        [DllImport("lab1.1.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr AddChars(String a, String b);

        static void Main(string[] args)
        {
            Console.WriteLine("adding 3+2");

            int adds = AddInts(3, 2);

            Console.WriteLine($"Svaret er: {adds}");

            Console.WriteLine("adding two chars  meep and boop");

            //DEN med strings er en complex type i c++ som kan udvide sig.
            //Den er ikke kompatipel derfor skal ha bruge char pointers vis man vil ha det over.

            IntPtr mystring = AddChars("meep", "boop");

            string marshall = Marshal.PtrToStringAnsi(mystring);

            Console.WriteLine($"now it is: {marshall}");
        }
    }
}
