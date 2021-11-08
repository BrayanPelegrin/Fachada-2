using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0.Presistencias
{
    class Json:IEstrategia
    {

        public void Persistencia(string nombre, long cedula, string departamento, double salario, double ARS, double AFP, double planFunetario, double Coperativa)
        {

            TextWriter txt = new StreamWriter("Empleado.json");

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
