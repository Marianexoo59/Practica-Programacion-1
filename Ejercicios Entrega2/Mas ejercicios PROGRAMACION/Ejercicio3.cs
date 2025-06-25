using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public interface IConectable
    {
        public void Conectar(string conectado);
        public void Desconectar(string desconectado);
    }
    public class Impresora : IConectable
    {
        public void Conectar(string conectado)
        {
            Console.WriteLine($"La impresora esta {conectado}");
        }
        public void Desconectar(string desconectado)
        {
            Console.WriteLine($"La impresora esta {desconectado}");
        }
    }
    public class Teclado : IConectable
    {
        public void Conectar(string conectado)
        {
            Console.WriteLine($"El teclado esta {conectado}");
        }
        public void Desconectar(string desconectado)
        {
            Console.WriteLine($"El teclado esta {desconectado}");
        }
    }

    public class Monitorsito : IConectable
    {
        public void Conectar(string conectado)
        {
            Console.WriteLine($"El monitor esta {conectado}");
        }
        public void Desconectar(string desconectado)
        {
            Console.WriteLine($"El monitor esta {desconectado}");
        }
    }
}
