using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0.Presistencias
{
    class Xlsx:IEstrategia
    {
        private string ruta = AppDomain.CurrentDomain.BaseDirectory + "Empleado.xlsx";

        public void Persistencia(string nombre, long cedula, string departamento, double salario, double ARS, double AFP, double planFunetario, double Coperativa)
        {
            SLDocument sLDocument = new SLDocument();
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("Atributo", typeof(String));
            dt.Columns.Add("Valor", typeof(String));

            dt.Rows.Add("Nombre: ",nombre);
            dt.Rows.Add("Cedula: ",cedula);
            dt.Rows.Add("Departamento: ",departamento);
            dt.Rows.Add("Salario: ",salario.ToString());
            dt.Rows.Add("ARS: ",ARS.ToString());
            dt.Rows.Add("AFP: ",AFP.ToString());
            dt.Rows.Add("Plan Funerario: ",planFunetario.ToString());
            dt.Rows.Add("Cooperativa: ",Coperativa.ToString());

            sLDocument.ImportDataTable(1, 1, dt, true);
            sLDocument.SaveAs(ruta);


            
        }
    }
}
