using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public interface INotificable 
    {
        public void Notificar(string mensaje);
    }

    public class Email : INotificable
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
    public class SMS : INotificable
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
    public class PushNotification : INotificable
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
