using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    [Serializable]
    public class CapaAplicacionException:ApplicationException
    {
        public CapaAplicacionException(string message, ErrorPuntualException exception) : base(message, exception)
        { 
        }
    }
}
