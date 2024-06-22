using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pago
{
    public  abstract class persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }


        public abstract void MostrarDetalles();
    }
}
