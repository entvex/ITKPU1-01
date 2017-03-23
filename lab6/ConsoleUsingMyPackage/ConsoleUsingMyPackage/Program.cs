using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CprCheck_lab1;

namespace ConsoleUsingMyPackage
{
    class Program
    {
        static void Main(string[] args)
        {

            var cprDll = new CprDll();

            CprError cprError;

            cprDll.Check("2506951234", out cprError);

            Console.WriteLine(cprError == CprError.NoError
                ? "Det er et rigtigt CPR nummer."
                : $"Der er noget galt!!!: {cprError}");
        }
    }
}
