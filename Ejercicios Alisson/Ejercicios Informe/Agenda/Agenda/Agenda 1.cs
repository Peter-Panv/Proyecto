using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    // Clase abstracta para una entrada en la agenda
    public abstract class EntradaAgenda
    {
        public DateTime Fecha { get; set; }
        public string NombrePaciente { get; set; }
        public string Descripcion { get; set; }

        protected EntradaAgenda(DateTime fecha, string nombrePaciente, string descripcion)
        {
            Fecha = fecha;
            NombrePaciente = nombrePaciente;
            Descripcion = descripcion;
        }

        // Método abstracto que debe ser implementado por las clases derivadas
        public abstract void MostrarEntrada();
    }
}
