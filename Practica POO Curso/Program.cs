namespace Practica_POO_Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hacerTarea();
        }
        static void hacerTarea()
        {
            Punto origen = new Punto();

            Punto destino = new Punto(150,90);

            Punto otroPunto = new Punto();

            double distancia = origen.DistanciaPuntos(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.contarObjetos}");

        }
    }
}
