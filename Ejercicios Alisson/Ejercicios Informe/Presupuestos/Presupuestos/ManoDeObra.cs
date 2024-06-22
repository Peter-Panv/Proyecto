using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuestos
{
    internal class ManoDeObra
    {
        // Clase para un presupuesto de mano de obra
        public class PresupuestoManoObra : presupuesto
        {
            public string Descripcion { get; set; }
            public decimal Monto { get; set; }
            public int HorasEstimadas { get; set; }
            public decimal CostoPorHora { get; set; }

            public PresupuestoManoObra(string descripcion, decimal monto, int horasEstimadas, decimal costoPorHora)
            {
                Descripcion = descripcion;
                Monto = monto;
                HorasEstimadas = horasEstimadas;
                CostoPorHora = costoPorHora;
            }

            public void MostrarDetalles()
            {
                Console.WriteLine($"Presupuesto de Mano de Obra: {Descripcion}");
                Console.WriteLine($"Monto: {Monto:C}");
                Console.WriteLine($"Horas Estimadas: {HorasEstimadas}");
                Console.WriteLine($"Costo por Hora: {CostoPorHora:C}");
            }
        }
    }
}
