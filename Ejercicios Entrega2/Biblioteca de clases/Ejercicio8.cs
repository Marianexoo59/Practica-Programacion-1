using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public interface IArchivo
    {
        public void Abrir();
        public void Cerrar();
    }

    public class Documento : IArchivo
    {
        public void Abrir()
        {
            Console.WriteLine("El docuemnto se abrio");
        }
        public void Cerrar()
        {
            Console.WriteLine("El documento se cerro");
        }
    }
    public class Imagen : IArchivo
    {
        public void Abrir()
        {
            Console.WriteLine("Mostrando imagen en la pantalla");
        }
        public void Cerrar()
        {
            Console.WriteLine("La imagen se quito de la pantalla");
        }
    }

    public class Video : IArchivo
    {
        public void Abrir()
        {
            Console.WriteLine("El video se abrio con exito y se esta reproduciendo");
        }
        public void Cerrar()
        {
            Console.WriteLine("El video se cerro y se dejo de reproducir");
        }
    }
}
