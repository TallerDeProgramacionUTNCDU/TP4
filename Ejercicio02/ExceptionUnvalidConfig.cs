using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    public class ExceptionUnvalidConfig : ApplicationException
    {
        private DateTime iFechayHora;
        public ExceptionUnvalidConfig(string message) : base(message) { iFechayHora = DateTime.Now; }
        public DateTime FechayHora
        {
            get { return iFechayHora; }
            set { iFechayHora = value; }

        }
    }
}
