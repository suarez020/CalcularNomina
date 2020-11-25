using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularNomina
{
    public class Nomina
    {
        //private int diaslaborados;
   

        public int DiasLaborados { get; set; }

        //metodo para calcular la nomina 
        public decimal CalcularNomina(int diaslab, decimal valorDia)
        {
            decimal totalSalario = diaslab * valorDia;
            return totalSalario;
        }
    }
}
