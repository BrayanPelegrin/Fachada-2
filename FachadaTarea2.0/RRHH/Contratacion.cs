using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0.RRHH
{
    class Contratacion:IFachada
    {
        Nomina.AccionPersonal ap = new Nomina.AccionPersonal();
        public void Sistema()
        {
            Console.WriteLine("---Contratacion---");
            Console.Write("Digite el nombre completo-> ");
            string nombre = Console.ReadLine();
            Console.Write("Digite su Cedula(sin guiones)-> ");
            long cedula = long.Parse(Console.ReadLine());
            Console.Write("Digite el departamento-> ");
            string departamento = Console.ReadLine();
            double salario = 0;
            Console.Write("Desea afiliarse al Plan Funetario (S/N) -> ");
            string D = Console.ReadLine();
            bool planFunetario = false;
            bool cooperativa = false;
            if (D == "S" || D == "s") 
            {
               planFunetario = true;
                ap.NotificarPlan(planFunetario);
            }
            if(D == "N" || D == "n") 
            {
                planFunetario = false;
                ap.NotificarPlan(planFunetario);
            }
            Console.Write("Desea afiliarse al Plan de la Coperativa (S/N) -> ");
            D = Console.ReadLine();
            if (D == "S" || D == "s") { cooperativa = true; ap.NotificarPlan(cooperativa); }
            if (D == "N" || D == "n") { cooperativa = false; ap.NotificarPlan(cooperativa); }
            Cliente.empleados.Add(new Datos() { nombre = nombre, cedula = cedula, departamento = departamento, salario = salario, cooperativa = cooperativa, planFunetario = planFunetario });
        }
        
        
    }
}
