using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class CapaDominio
    {
        public void HaciaPersistencia()
        {
            var persistencia = new CapaPersistencia();
            persistencia.LanzarExcepcion();
        }


    }
}
