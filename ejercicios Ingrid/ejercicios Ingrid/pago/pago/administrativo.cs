using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pago
{
    public class administrativo : persona, iempleado
    {
        public string Departamento { get; set; }
        public decimal SueldoBase { get; set; }
        public decimal salario { get; set; }

        public void CalcularSalario()
        {

           salario = SueldoBase;

        }

        public void MostrarSalario()
        {

            Console.WriteLine($"El salario del administrativo {Nombre} es: {salario}");
        }


        public override void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Departamento: {Departamento}");
        }
    }
}
