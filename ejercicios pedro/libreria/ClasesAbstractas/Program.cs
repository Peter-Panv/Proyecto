using System;

namespace Biblioteca
{
    // Clase abstracta ElementoBiblioteca
    public abstract class ElementoBiblioteca
    {
        // Propiedades comunes a todos los elementos de la biblioteca
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }

        // Constructor
        public ElementoBiblioteca(string titulo, string autor, int añoPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
        }

        // Método abstracto para mostrar la información del elemento
        public abstract void MostrarInformacion();

        // Método virtual que puede ser sobrescrito en las clases derivadas
        public virtual void Prestar()
        {
            Console.WriteLine("El elemento ha sido prestado.");
        }
    }

    // Clase Libro que hereda de ElementoBiblioteca
    public class Libro : ElementoBiblioteca
    {
        // Propiedad específica de la clase Libro
        public int NumeroPaginas { get; set; }

        // Constructor
        public Libro(string titulo, string autor, int añoPublicacion, int numeroPaginas)
            : base(titulo, autor, añoPublicacion)
        {
            NumeroPaginas = numeroPaginas;
        }

        // Implementación del método abstracto MostrarInformacion
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Libro: {Titulo}, Autor: {Autor}, Año: {AñoPublicacion}, Páginas: {NumeroPaginas}");
        }

        // Sobrescribir el método Prestar
        public override void Prestar()
        {
            Console.WriteLine($"El libro '{Titulo}' ha sido prestado.");
        }
    }

    // Clase Revista que hereda de ElementoBiblioteca
    public class Revista : ElementoBiblioteca
    {
        // Propiedad específica de la clase Revista
        public int NumeroEdicion { get; set; }

        // Constructor
        public Revista(string titulo, string autor, int añoPublicacion, int numeroEdicion)
            : base(titulo, autor, añoPublicacion)
        {
            NumeroEdicion = numeroEdicion;
        }

        // Implementación del método abstracto MostrarInformacion
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Revista: {Titulo}, Autor: {Autor}, Año: {AñoPublicacion}, Edición: {NumeroEdicion}");
        }

        // Sobrescribir el método Prestar
        public override void Prestar()
        {
            Console.WriteLine($"La revista '{Titulo}' ha sido prestada.");
        }
    }

    // Programa para probar las clases
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de Libro y Revista
            Libro libro = new Libro("Cien Años de Soledad", "Gabriel García Márquez", 1967, 417);
            Revista revista = new Revista("National Geographic", "Varios Autores", 2023, 202);

            // Mostrar información y prestar elementos
            libro.MostrarInformacion();
            libro.Prestar();
            revista.MostrarInformacion();
            revista.Prestar();
        }
    }
}
