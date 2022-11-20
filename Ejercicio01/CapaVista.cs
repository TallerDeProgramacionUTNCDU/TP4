using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class CapaVista
    {
        public void HaciaControlador()
        {
            try
            {
                var controlador = new CapaControlador();
                controlador.HaciaAplicacion();
            }
            catch (CapaAplicacionException unaExcepcion)
            {
                Console.WriteLine("Tipo de Excepción Encontrada: \n {0} \n", unaExcepcion.GetType().Name);
                Console.WriteLine("Ha ocurrido una Excepción: \n {0} \n", unaExcepcion.Message);
                Console.WriteLine("Excepción Original: \n  {0}  \n", unaExcepcion.InnerException.Message);
                Console.WriteLine("Call Stack: \n {0} \n", unaExcepcion.StackTrace);
            }
        }

    }
}
