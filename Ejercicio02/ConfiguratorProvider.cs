using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
   public class ConfiguratorProvider:iProvideConfiguration
    {
        public Dictionary<string, ConfigurationBase> iCache= new Dictionary<string, ConfigurationBase>();
        public FileManager admin= new FileManager();
        public static string path= @"C:\Users\santi\Desktop\TP4"; //Ingresar la ruta a la que se accede
        public void DictionarySet()
        {
            var obj1 = new ServiceConfiguration("BaseUrl", "ClientId", "ClientSecret");
            iCache.Add("ServiceConfiguration", obj1);
        }
        public ConfigurationBase Provide(string pConfig)
        {
               
            var buscado = iCache.TryGetValue(pConfig, out var config);
            if (buscado) { return config; }
                else
                {
                    try
                    {
                        var pathFile = admin.GetPathFile(pConfig, path);
                        var foundConfig = admin.GetConfigFromFile(pathFile);
                        iCache.Add(pConfig, foundConfig);
                        return foundConfig;
                    }
                    catch (ExceptionFileNotFound fileNotFound) { throw new ExcepcionGeneric("Se ha producido un error", fileNotFound); }
                }
        }
    }
}
