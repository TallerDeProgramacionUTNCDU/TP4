using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class CapaAplicacion
    {
        public void HaciaDominio()
        {
            try
            {
                var dominio = new CapaDominio();
                dominio.HaciaPersistencia();
            }
            catch (ErrorPuntualException unError)
            {
                var aplicacionExcepcion = new CapaAplicacionException("Se ha producido un Error",unError);
                throw aplicacionExcepcion;
            }
        }

    }
}
