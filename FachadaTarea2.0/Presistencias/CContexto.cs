using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0.Presistencias
{
    class CContexto
    {
        IEstrategia estrategia;
        public CContexto(IEstrategia objeto)
        {
            this.estrategia = objeto;
        }
        public void Impresion(string nombre, long cedula, string departamento, double salario , double ARS, double AFP, double planFunetario, double Coperativa)
        {
            estrategia.Persistencia( nombre,  cedula,  departamento,  salario,  ARS, AFP, planFunetario,  Coperativa);
        }
    }
}
