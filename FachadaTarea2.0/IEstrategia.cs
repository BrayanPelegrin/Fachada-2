using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0
{
    interface IEstrategia
    {
        void Persistencia(string nombre, long cedula, string departamento, double salario, double ARS, double AFP, double planFunetario, double Coperativa);
    }
}
