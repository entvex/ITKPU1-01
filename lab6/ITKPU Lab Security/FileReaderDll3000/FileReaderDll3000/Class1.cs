using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderDll3000
{
    public class UntrustedClass
    {

        public static string FileReaderDll3000TheGateToLove(string fileToRead)
        {
            return System.IO.File.ReadAllLines(fileToRead).ToString();
        } 
    }
}
