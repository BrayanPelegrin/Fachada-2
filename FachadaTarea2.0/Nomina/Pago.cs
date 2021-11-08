using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0.Nomina
{
    class Pago : IFachada
    {
       
        Cliente cliente = new Cliente();
        public void Sistema()
        {
            Console.Write("Digite la cedula del empleado al que desea Pagar(sin guiones)-> ");
            long cedula = long.Parse(Console.ReadLine());
            Buscar.buscar(cedula);
            Pagar(cedula);
        }

        public void Pagar(long cedula) 
        {
            AccionPersonal ap = new AccionPersonal();
            
            double planfunetario, cooperativa;
            
            foreach (Datos x in Cliente.empleados)
            {

                if (cedula == x.cedula)
                {
                    double ARS;
                    double AFP;


                    Console.Write("Digite la cantidad que desea pagar al empleado (El monto minimos es de 10,000)-> ");
                    int salario = int.Parse(Console.ReadLine());
                    x.salario = x.salario + salario;
                    AFP = AccionPersonal.AFP(salario);
                    ARS = AccionPersonal.ARS(salario);
                    if (x.planFunetario == true && salario > 10000)
                    {
                        planfunetario = AccionPersonal.PlanFunetario(salario);
                        Console.WriteLine($"El Descuento del plan funerario aplicado es de: {planfunetario}");
                        Console.WriteLine(" presione cualquier tecla para continuar..."); Console.ReadKey();
                        x.salario = x.salario - planfunetario;
                        ap.Notificar(x.salario);

                    }
                    else { planfunetario = 0; }
                    if (x.cooperativa == true)
                    {
                        cooperativa = AccionPersonal.Cooperativa(salario);
                        Console.WriteLine($"El Descuento del plan de la coperativa aplicado es de: {cooperativa}");
                        Console.WriteLine(" presione cualquier tecla para continuar..."); Console.ReadKey();
                        x.salario = x.salario - cooperativa;
                        ap.Notificar(x.salario);
                    }
                    else { cooperativa = 0; }

                    MenuImpresion.impresora(x.nombre, cedula, x.departamento, x.salario, ARS, AFP, planfunetario, cooperativa);



                }
                else { Console.WriteLine("Empleado no encontrado, presione cualquier tecla para continuar..."); Console.ReadKey(); Sistema(); }

            }
                
            
        }

        
    }
}
