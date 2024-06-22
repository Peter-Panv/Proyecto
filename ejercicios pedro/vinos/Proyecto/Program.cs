using Proyecto;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        IBebidaAlcoholica oBebidaC = new Cerveza();
        IBebidaAlcoholica oBebidaV = new VinoTinto();

        // Configurar las propiedades de las bebidas
        oBebidaC.Datos(5, "Botella", "Corona");
        oBebidaC.Llenar(500);

        oBebidaV.Datos(12, "Botella", "Casillero del Diablo");
        oBebidaV.Llenar(750);

        var list = new List<IBebida>();

        list.Add(oBebidaC);
        list.Add(oBebidaV);

        Mostrar(list);
    }

    public static void Mostrar(List<IBebida> list)
    {
        foreach (var oElement in list)
        {
            Console.WriteLine(oElement.Mostrar());
        }
    }

    //interfaz I
    public interface IBebida
    {
        int Cantidad { get; set; }
        string Mostrar();
    }

    //Interfaz II
    public interface IBebidaAlcoholica : IBebida
    {
        int Alcohol { get; set; }
        string Presentacion { get; set; }
        string Marca { get; set; }

        void Llenar(int NuevaCantidad);

        void Datos(int NuevoAlcohol, string NuevaPresentacion, string NuevaMarca);

    }

    //Tiene que cumplir las propiedades de IBebidaAlcoholica
    public class Cerveza : IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public string Presentacion { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }

        public void Llenar(int NuevaCantidad)
        {
            this.Cantidad = NuevaCantidad;
        }

        //Metodo Para mostrar en cosola la cerveza
        public string Mostrar()
        {
            return $"Cerveza - Marca: {this.Marca}, Presentación: {this.Presentacion}, Grado de Alcohol: {this.Alcohol}%, Cantidad: {this.Cantidad}ml";

        }

        public void Datos(int NuevoAlcohol, string NuevaPresentacion, string NuevaMarca)
        {
            this.Alcohol = NuevoAlcohol;
            this.Presentacion = NuevaPresentacion;
            this.Marca = NuevaMarca;
        }
    }


    public class VinoTinto : IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public string Presentacion { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }

        public void Llenar(int NuevaCantidad)
        {
            this.Cantidad = NuevaCantidad;
        }

        //Metodo Para mostrar en cosola el vino tinto

        public string Mostrar()
        {
            return $"Vino Tinto - Marca: {this.Marca}, Presentación: {this.Presentacion}, Grado de Alcohol: {this.Alcohol}%, Cantidad: {this.Cantidad}ml";
        }

        public void Datos(int NuevoAlcohol, string NuevaPresentacion, string NuevaMarca)
        {
            this.Alcohol = NuevoAlcohol;
            this.Presentacion = NuevaPresentacion;
            this.Marca = NuevaMarca;
        }
    }
}


