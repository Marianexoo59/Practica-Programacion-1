using System;
namespace Ejercicios

{
        public class Animal()
        {
            public virtual void hacerSonido()
            {
                Console.WriteLine("*Hace un sonido*");
            }
        }

        public class Perro : Animal
        {
            public override void hacerSonido()
            {
                Console.WriteLine("Guau");
            }
        }

        public class Vaca : Animal
        {
            public override void hacerSonido()
            {
                Console.WriteLine("Muuuu");
            }
        }
}
