using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuestos
{
    public interface presupuesto
    
      
    {
        // Interfaz para un presupuesto
        
            string Descripcion { get; set; }
            decimal Monto { get; set; }

            void MostrarDetalles();
        

    }
}
