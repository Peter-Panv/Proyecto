using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuestos
{
    internal class materiales : presupuesto
    {
        // Clase para un presupuesto de materiales


        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public List<string> ListaMateriales { get; set; }

        public materiales(string descripcion, decimal monto, List<string> listaMateriales)
        {
            Descripcion = descripcion;
            Monto = monto;
            ListaMateriales = listaMateriales;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Presupuesto de Materiales: {Descripcion}");
            Console.WriteLine($"Monto: {Monto:C}");
            Console.WriteLine("Lista de Materiales:");
            foreach (var material in ListaMateriales)
            {
                Console.WriteLine($"- {material}");
            }
        }
    }
}

