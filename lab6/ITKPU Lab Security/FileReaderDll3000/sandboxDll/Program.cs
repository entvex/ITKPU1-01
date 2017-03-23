using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace sandboxDll
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteUntrustedCode("FileReaderDll3000", "FileReaderDll3000.UntrustedClass", "FileReaderDll3000TheGateToLove", new []{ "C:\\Windows\\System32\\xpsrchvw.xml" });

        }

        public static void ExecuteUntrustedCode(string assemblyName, string typeName, string entryPoint, Object[] parameters)
        {
            //Load the MethodInfo for a method in the new assembly. This might be a method you know, or   
            //you can use Assembly.EntryPoint to get to the entry point in an executable.  
            MethodInfo target = Assembly.Load(assemblyName).GetType(typeName).GetMethod(entryPoint);
            try
            {
                // Invoke the method.  
                target.Invoke(null, parameters);
            }
            catch (Exception ex)
            {
                //When information is obtained from a SecurityException extra information is provided if it is   
                //accessed in full-trust.  
                (new PermissionSet(PermissionState.Unrestricted)).Assert();
                Console.WriteLine("SecurityException caught:\n{0}", ex.ToString());
                CodeAccessPermission.RevertAssert();
                Console.ReadLine();
            }
        }
    }
}


