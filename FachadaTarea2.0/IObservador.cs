using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0
{
    interface IObservador
    {
        void NotificarPlan(bool plan);
        void Notificar(double sueldo);
    }
}
