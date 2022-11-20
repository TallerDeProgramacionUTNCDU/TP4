using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio_02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            try
            {
                var provider = new ConfiguratorProvider();
                //provider.DictionarySet();
                var config = provider.Provide("ServiceConfiguration");
                Console.WriteLine(config);
            }
            catch (ExcepcionGeneric excepcion)
            { Console.Write(excepcion.Message);
                Console.WriteLine(": "+excepcion.InnerException.Message); }
        }
    }
}
