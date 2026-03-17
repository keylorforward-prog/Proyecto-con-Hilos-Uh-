using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaSalarios
{
    public class Cla_Empleado
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public int Genero { get; set; }
        public double Salario_Mensual { get; set; }
        public bool Salario_Menor { get; set; }
        public bool Salario_Mayor { get; set; }
    }
}