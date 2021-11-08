using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaTarea2._0
{
    class MenuImpresion
    {
        public static void impresora(string nombre, long cedula, string departamento, double salario, double ARS, double AFP, double planFunetario, double Coperativa)
        {
            Presistencias.CContexto contexto = null;
            Console.Clear();
            Console.WriteLine("---Menu de Impresion---\n");
            Console.Write("a) Txt \nb) Xlsx \nc)Json \nOpcion-> ");
            string opcion = Console.ReadLine().ToLower();
            switch (opcion)
            {
                case "a":
                    {
                        Presistencias.Txt txt = new Presistencias.Txt();
                        contexto = new Presistencias.CContexto(txt); break;
                    }

                case "b":
                    {
                        Presistencias.Xlsx xlsx = new Presistencias.Xlsx();
                        contexto = new Presistencias.CContexto(xlsx); break;
                    }

                case "c":
                    {
                        Presistencias.Json json = new Presistencias.Json();
                        contexto = new Presistencias.CContexto(json); break;
                    }
            }
            contexto.Impresion(nombre, cedula, departamento, salario, ARS, AFP, planFunetario, Coperativa);
        }
    }
}
