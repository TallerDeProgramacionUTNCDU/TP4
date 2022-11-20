using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class CapaPersistencia
    {
        public void LanzarExcepcion()
        {
            var excepcion = new ErrorPuntualException("This is an ErrorPuntualException");
            throw excepcion;
        }
    }
}
