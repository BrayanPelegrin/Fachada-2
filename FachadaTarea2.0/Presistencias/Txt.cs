using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace FachadaTarea2._0.Presistencias
{
    class Txt:IEstrategia
    {

        public void Persistencia(string nombre, long cedula, string departamento, double salario, double ARS, double AFP, double planFunetario, double Coperativa)
        {
      
            TextWriter txt = new StreamWriter("Empleado.txt");

                txt.WriteLine($"Nombre del Empleado: {nombre}\n" +
                    $"Cedula del empleado: {cedula}\n" +
                    $"Departamento: {departamento}\n" +
                    $"Salario: {salario}\n" +
                    $"ARS: {ARS}\n" +
                    $"AFP: {AFP}\n" +
                    $"Plan Funerario: {planFunetario}\n" +
                    $"Coperativa: {Coperativa}");

                txt.Close();
            
        }
    }
}
