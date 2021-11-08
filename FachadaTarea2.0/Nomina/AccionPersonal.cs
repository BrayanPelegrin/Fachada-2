using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0.Nomina
{
    class AccionPersonal:IObservador
    {
 
        public static double ARS(int salario) 
        {
            double ars;
            ars = salario * 0.031;

            return ars;
        }

        public static double AFP(int salario)
        {
            double afp;
            afp = salario * 0.0287;

            return afp;
        }

        public static double PlanFunetario(int salario)
        {
            double planFunetario;
            planFunetario = salario * 0.02;

            return planFunetario;
        }

        public static double Cooperativa(int salario)
        {
            double cooperativa;
            cooperativa = salario * 0.05;

            return cooperativa;
        }

        public void NotificarPlan(bool plan)
        {
            if (plan == true)
            {
                Console.WriteLine($"El Descuento del plan  ha sido aplicado Exitosamente");
            }
            else { Console.WriteLine($"El Descuento del plan  se ha Rechazado Exitosamente"); }
        }

        public void Notificar(double sueldo) 
        {
             
            
                Console.WriteLine($"Su sueldo Con el descuento es de {sueldo}");
                Console.WriteLine("presione cualquier tecla para continuar...");
                Console.ReadKey();
            
        }
    }
}
