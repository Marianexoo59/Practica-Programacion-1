using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public interface IVehiculo
    {
        void Conducir();
    }

    public class Auto : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("Conduciendo un auto.");
        }
    }

    public class Bicicleta : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("Conduciendo una bicicleta.");
        }
    }
}
