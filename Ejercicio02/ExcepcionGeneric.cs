using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    public class ExcepcionGeneric:ApplicationException
    {
        public ExcepcionGeneric(string message, ApplicationException exception) : base(message, exception)
        {
        }
    }
}
