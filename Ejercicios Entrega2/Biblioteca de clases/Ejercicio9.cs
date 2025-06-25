using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public interface IImprimible
    {
        public void Imprimir()
        {
        }
    }
    public class Factura : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo factura...");
        }
    }
    public class Contrato : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo contrato...");
        }
    }
    public class Etiqueta : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo etiqueta...");
        }
    }
}
