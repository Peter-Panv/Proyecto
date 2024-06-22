using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Programa
    {
        static void Main(string[] args)
        {
            CitaMedica cita = new CitaMedica(
                new DateTime(2024, 7, 1, 10, 0, 0),
                "Juan Pérez",
                "García",
                "Chequeo General"
            );

            Cirugia cirugia = new Cirugia(
                new DateTime(2024, 7, 2, 8, 0, 0),
                "Ana López",
                "Martínez",
                "Apendicectomía"
            );

            cita.MostrarEntrada();
            cirugia.MostrarEntrada();
        }
    }


}
