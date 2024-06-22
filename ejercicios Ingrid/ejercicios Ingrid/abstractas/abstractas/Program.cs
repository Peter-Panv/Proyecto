
namespace abstractas
{
    internal class Program
{
    static void Main()
    {
        // Crear instancias de Coche y Moto
        Coche miCoche = new Coche("Toyota", "Corolla", 2020);
        Moto miMoto = new Moto("Honda", "CBR500R", 2021);

        // Llamar al método Conducir de cada instancia
        miCoche.Conducir();
        miMoto.Conducir();
    }
}
}




