using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    public class ExceptionFileNotFound : ApplicationException
    {
            private DateTime iFechayHora;
            public ExceptionFileNotFound(string message) : base(message) { iFechayHora = DateTime.Now; }
    }
}
