using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicios
{
    
    
        public class Persona
        {
            public string nombre { get; set; }
            public int edad { get; set; }
            public Direccion datosDireccion { get; set; }

            public void Datos(string nombre, int edad, Direccion datosDireccion)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.datosDireccion = datosDireccion;
            }
            public Persona(string nombre, int edad, Direccion datosDireccion)
            {
            this.nombre = nombre;
            this.edad = edad;
            this.datosDireccion = datosDireccion;
            }
        }

        public class Direccion
        {
            public string calle { get; set; }
            public string ciudad { get; set; }

            public Direccion(string calle, string ciudad)
        {
            this.calle = calle;
            this.ciudad = ciudad;
        }

         public void datosDireccion(string calle, string ciudad)
            {
                this.calle = calle;
                this.ciudad = ciudad;
            }
        }
    
}
