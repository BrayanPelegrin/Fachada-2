using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0
{
    class Buscar
    {
        public static int buscar(long cedula)
        {
            int contador = 0;
            
            foreach (Datos x in Cliente.empleados)
            {

                if (cedula == x.cedula)
                {
                    Console.WriteLine($"Nombre del empleado: {x.nombre} \nCedula: {x.cedula} \nDepartamento: {x.departamento} \nSalario: {x.salario}");

                    return contador;
                }
                else { Console.WriteLine("Empleado no encontrado, presione cualquier tecla para continuar..."); Console.ReadKey();  }
                contador += 1;


            }
            return 0;
        }
    }
}
