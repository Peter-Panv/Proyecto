using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public abstract class TrianguloBase
    {
        public abstract decimal Perimetro();

        public abstract decimal Area();
        
        public decimal  CalcularAreaTrianguloConHipotenusa(double lado, double hipotenusa)
        {
            double ladob = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(lado, 2));
            return (decimal)(lado * lado / 2);
        }   
    }

    public class Escaleno : TrianguloBase
    {
        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }

        public override decimal Area()
        {
            throw new NotImplementedException();
        }

    }

    public class Acutangulo : TrianguloBase
    {
        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }

        public override decimal Area()
        {
            throw new NotImplementedException();
        }

    }
}
