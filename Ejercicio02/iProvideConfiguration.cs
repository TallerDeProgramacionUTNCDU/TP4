using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    public interface iProvideConfiguration
    {
        ConfigurationBase Provide(string configurationBase);
    }
}
