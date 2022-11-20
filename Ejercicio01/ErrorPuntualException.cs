using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    [Serializable]
    public class ErrorPuntualException:ApplicationException
    {
        private DateTime iFechayHora;
        public ErrorPuntualException(string mensaje) : base(mensaje)
        {
               iFechayHora= DateTime.Now;
        }
    }
}
