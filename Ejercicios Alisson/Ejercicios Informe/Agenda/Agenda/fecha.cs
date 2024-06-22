using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class CitaMedica : EntradaAgenda
    {
        public string NombreDoctor { get; set; }

        public CitaMedica(DateTime fecha, string nombrePaciente, string nombreDoctor, string motivo)
            : base(fecha, nombrePaciente, motivo)
        {
            NombreDoctor = nombreDoctor;
        }

        public override void MostrarEntrada()
        {
            Console.WriteLine($"Cita Médica el {Fecha} con el Dr. {NombreDoctor}");
            Console.WriteLine($"Paciente: {NombrePaciente}");
            Console.WriteLine($"Motivo: {Descripcion}");
        }
    }
}
