using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pago
{
    public class profesor:persona, iempleado
    {
        

    public string Materia { get; set; }
        public int HorasDictadas { get; set; }
        public decimal TarifaPorHora { get; set; }
        public decimal salario { get; set; }


        public void CalcularSalario()
        {
             salario = HorasDictadas * TarifaPorHora;
            
        }

        public void MostrarSalario()
        {
            
            Console.WriteLine($"El salario del profesor {Nombre} es: {salario}");
        }

        
        public override void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Materia: {Materia}");
        }
    }
}
