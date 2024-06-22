using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agenda
{
    public class Cirugia : EntradaAgenda
    {
        public string NombreCirujano { get; set; }

        public Cirugia(DateTime fecha, string nombrePaciente, string nombreCirujano, string procedimiento)
            : base(fecha, nombrePaciente, procedimiento)
        {
            NombreCirujano = nombreCirujano;
        }

        public override void MostrarEntrada()
        {
            Console.WriteLine($"Cirugía programada el {Fecha} con el Cirujano {NombreCirujano}");
            Console.WriteLine($"Paciente: {NombrePaciente}");
            Console.WriteLine($"Procedimiento: {Descripcion}");
        }
    }
}


