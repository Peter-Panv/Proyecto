using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractas
{
    
        public class Coche : Vehiculo
        {
            // Constructor de la clase Coche
            public Coche(string marca, string modelo, int anio)
                : base(marca, modelo, anio)
            {
            }

            // Implementación del método abstracto Conducir
            public override void Conducir()
            {
                Console.WriteLine($"Conduciendo el coche {Marca} {Modelo} de {Año}");
            }
        }
    
}
