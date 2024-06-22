using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractas
{
    public abstract class Vehiculo
    {
        // Propiedades comunes a todos los vehículos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

        // Constructor de la clase abstracta
        protected Vehiculo(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        // Método abstracto que debe ser implementado por las clases derivadas
        public abstract void Conducir();
    }
}
