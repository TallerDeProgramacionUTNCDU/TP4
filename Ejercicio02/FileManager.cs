using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_02
{
    public class FileManager
    {
        public string GetPathFile(string pFileName,string pathToSearch)
        {
            string found=null;
            string[] fileEntries = Directory.GetFiles(pathToSearch);
            foreach (string fileName in fileEntries)
            {
                if (Path.GetFileNameWithoutExtension(fileName)==pFileName) { found= fileName; }
            }
            if (found is null) { throw new ExceptionFileNotFound("File Not Found"); }
            else { return found; }
        }
        public ConfigurationBase GetConfigFromFile(string pFilePath)
        {
            ConfigurationBase configuracion=null;
            var filename = Path.GetFileNameWithoutExtension(pFilePath);
            StreamReader file = File.OpenText(pFilePath);
            JsonTextReader reader = new JsonTextReader(file);
            JObject o2 = (JObject)JToken.ReadFrom(reader);
            var url = o2.GetValue("BaseUrl");
            var clientId = o2.GetValue("ClientId");
            var clientSecret = o2.GetValue("ClientSecret");
            var timeoutS = o2.GetValue("Timeout");
            switch (filename)
            {
                case "ServiceConfiguration":
                    try
                    {
                        var serviceConfig = new ServiceConfiguration(url.ToString(), clientId.ToString(), clientSecret.ToString());
                        serviceConfig.Validate();
                        if (timeoutS is not null) { serviceConfig.Timeout = Int32.Parse(timeoutS.ToString()); }
                        configuracion=serviceConfig;
                    }
                    catch (ExceptionUnvalidConfig unvalid) { throw new ExcepcionGeneric("Se ha producido un Error", unvalid); }
                    break;
            }
            return configuracion;
        }
    }
}
