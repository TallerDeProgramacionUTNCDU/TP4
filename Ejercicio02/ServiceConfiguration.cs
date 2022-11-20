using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    public class ServiceConfiguration :ConfigurationBase
    {
        private string iBaseUrl;
        private string iClientId;
        private string iClientSecret;
        private int iTimeout;

        public ServiceConfiguration(string pUrl, string pId, string pSecret)
        { 
            iBaseUrl = pUrl;
            iClientId = pId;
            iClientSecret = pSecret; 
        }
        public override void Validate()
        {
            Uri uriResult;
            bool result = Uri.TryCreate(iBaseUrl, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (result is false) { var excepcion = new ExceptionUnvalidConfig("URL no válida"); throw excepcion;}
        }
        public string BaseUrl
        {
            get { return this.iBaseUrl; }
            set { this.iBaseUrl = value; }
        }
        public string ClientId
        {
            get { return this.iClientId; }
             set { this.iClientId = value; }
        }
        public string ClientSecret
        {
            get { return this.iClientSecret; }
            set { this.iClientSecret = value; }
        }
        public int Timeout
        {
            get { return this.iTimeout; }
            set { this.iTimeout = value; }
        }
    }
}
