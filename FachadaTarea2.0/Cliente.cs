using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0
{
    class Cliente
    {
        int O = 0;
        public static List<Datos> empleados = new List<Datos>();
       

        public void Menu()
        {
            RRHH.Contratacion contratacion = new RRHH.Contratacion();
            RRHH.Desvinculacion desvinculacion = new RRHH.Desvinculacion();
            Nomina.Pago pago = new Nomina.Pago();
            while (O != 4)
            {
                Console.WriteLine("/---Sistema RRHH---/");
                Console.WriteLine("1-Contratacion \n2-Desvinculacion \n3-Pago \n4-Salir");
                Console.Write("Opcion-> ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: { contratacion.Sistema(); break; }

                    case 2: { desvinculacion.Sistema(); break; }

                    case 3: { pago.Sistema(); break; }

                    case 4: { O = 4; break; }
                }
               
            }
        }
      
    }
}
