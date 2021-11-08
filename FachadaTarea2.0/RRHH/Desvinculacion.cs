using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0.RRHH
{
    class Desvinculacion : IFachada
    {
        Cliente cliente = new Cliente();
        public void Sistema()
        {
            Console.WriteLine("---Desvinculacion---\n");
            Console.Write("Digite la cedula del empleado a desvincular(sin guiones)-> ");
            int cedula = int.Parse(Console.ReadLine());
            int indice = Buscar.buscar(cedula);
            Console.Write("Digite la causa de Desvinculacion: ");
            string Causa = Console.ReadLine();
            Console.Write("Esta Seguro que quiere desvincular a este empleado? S/N ");
            string D = Console.ReadLine();
            if (D == "S" & D == "s")
            {
                Cliente.empleados.RemoveAt(indice);

                Console.WriteLine("Empleado Desvinculado Exitosamente");
                cliente.Menu();
            }
            if (D == "N" & D == "n")
            {
                Console.WriteLine("No se desvinculara a nadie, Volviedno al menu principal....");
                Console.ReadKey();
                cliente.Menu();
            }
            else { Console.WriteLine("Digita La Vaina bien"); Sistema(); }
        }

   
    }
    
}
