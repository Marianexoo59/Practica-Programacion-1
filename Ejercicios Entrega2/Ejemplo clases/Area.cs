using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_clases
{
        public  abstract class Figura()
        {
            public abstract double CalcularArea();
        }

        public class Circulo : Figura
        {
            public double Radio { get; set; }
            public Circulo(double Radio)
            {
                this.Radio = Radio;
            }
            public override double CalcularArea() 
            {
                double area = 3.14 * (Radio * Radio);
                Console.WriteLine("El area del circulo: " + area);
                return area;
            }
        }

        public class Rectangulo : Figura
        {
            public double Base {  get; set; }
            public double altura {  get; set; }

            public Rectangulo(double Base, double altura)
            {
                this.Base = Base;
                this.altura = altura;
            }
            public override double CalcularArea()
            {
                double area = 0;
                area = Base * altura;
                Console.WriteLine("El area del rectangulo es: " + area);
                return area;
            }
        }
    
}
