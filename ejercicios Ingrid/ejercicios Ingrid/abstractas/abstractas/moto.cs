using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractas
{
    public class Moto : Vehiculo
    {
        // Constructor de la clase Moto
        public Moto(string marca, string modelo, int año)
            : base(marca, modelo, año)
        {
        }

        // Implementación del método abstracto Conducir
        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo la moto {Marca} {Modelo} de {Año}");
        }
    }
}
