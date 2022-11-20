using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class CapaControlador
    {
        public void HaciaAplicacion()
        {
            var aplicacion = new CapaAplicacion();
            aplicacion.HaciaDominio();
        }

    }
}
