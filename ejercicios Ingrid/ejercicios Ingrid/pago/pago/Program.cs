using pago;

internal
    
    class Program
{
    private static void Main(string[] args)
    {
        {
            
            profesor profesor1 = new profesor
            {
                Nombre = "Juan Perez",
                Edad = 40,
                Materia = "Matemáticas",
                HorasDictadas = 50,
                TarifaPorHora = 80,
            };

            administrativo admin1 = new administrativo
            {
                Nombre = "María González",
                Edad = 35,
                Departamento = "Recursos Humanos",
                SueldoBase = 3000
            };

            
            profesor1.MostrarDetalles();
            profesor1.CalcularSalario();
            profesor1.MostrarSalario();

            admin1.MostrarDetalles();
            admin1.CalcularSalario();
            admin1.MostrarSalario();

            Console.ReadLine();
        }
    }
}