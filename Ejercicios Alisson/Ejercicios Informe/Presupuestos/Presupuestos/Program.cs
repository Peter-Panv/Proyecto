using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Presupuestos.ManoDeObra;

namespace Presupuestos
{
   class Programa
   {
        static void Main(string[] args)
        {
                // Crear una lista de materiales
                List<string> materiales = new List<string> { "Cemento", "Arena", "Grava" };

                // Crear instancias de los presupuestos
                presupuesto presupuestoMateriales = new materiales ("Construcción de cimientos", 5000m, materiales);
                presupuesto presupuestoManoObra = new PresupuestoManoObra("Construcción de cimientos", 2000m, 100, 20m);

                // Mostrar detalles de los presupuestos
                presupuestoMateriales.MostrarDetalles();
                presupuestoManoObra.MostrarDetalles();
        }
   }
    
}
