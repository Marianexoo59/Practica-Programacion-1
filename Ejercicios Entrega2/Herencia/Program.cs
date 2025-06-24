using Ejemplo_clases;
using System.Security.Cryptography.X509Certificates;
namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Empleado emp = new Empleado();

            //emp.Nombre = "Mariano";
            //emp.Edad = 20;
            //emp.Puesto = "Desarrollador de software";

            //emp.Saludar();
            //emp.Trabajar(); 

            // Empleado emp = new Empleado("Laura", 28, "Diseñadora");

            //Console.WriteLine("Datos del empleado");
            //Console.WriteLine($"Nombre: {emp.Nombre}");
            //Console.WriteLine($"Edad: {emp.Edad}");
            //Console.WriteLine($"Puesto: {emp.Puesto}");

            //Console.ReadLine(); 

            //Perro perro = new Perro();
            //perro.Nombre = "Alonso";

            //perro.hacerSonido();

            //Gato migato = new Gato();
            //migato.Nombre = "Yoda";

            //migato.hacerSonido();

            //List<Animal> animales = new List<Animal>();

            //animales.Add(new Perro());
            //animales.Add(new Gato());

            //foreach(Animal animalitos in animales)
            //{
            //    animalitos.hacerSonido();
            //}

            //Automovil auto = new Automovil(5);

            //Camion camioncito = new Camion(1200);

            //Circulo circulito = new Circulo(15);
            //circulito.CalcularArea();
            //Rectangulo rectangulito = new Rectangulo(10, 15);
            //rectangulito.CalcularArea();

            //Libro librito = new Libro("Juani mercadolibre Bonora");
            //Console.WriteLine("El nombre del libro es: " + librito.libro);

            //LibroDigital librote = new LibroDigital("Juani", 15, "Word");
            //Console.WriteLine($"El nombre del libro digital es {librote.libro}, el peso en MB es: {librote.pesoenmb}, y el formato es: {librote.formato}");

            //Producto productito = new Producto("Calabaza", 125);
            //Console.WriteLine($"El nombre del producto es {productito.nombre} y el precio es de: {productito.precio}");

            //ProductoPerecedero productote = new ProductoPerecedero("15/05/2053", "Atun enlatado", 531.21);
            //Console.WriteLine($"La fecha de caducidad del producto es: {productote.fechacaducidad}, el nombre del producto es: {productote.nombre} y el precio es de: ${productote.precio}");

            //ProductoElectronico productitote = new ProductoElectronico(23.43, "SI", "Monitor", 125.54);
            //Console.WriteLine($"El consumo del {productitote.nombre} es: {productitote.voltaje},\n Garantia: {productitote.tienegarantia} y el precio es: {productote.precio}");

            Persona personita = new Persona("Juani", 46044159);
            Console.WriteLine($"El dni de {personita.nombre}, es: {personita.dni} ");

            Estudiante estudiantito = new Estudiante(283745, "Juani", 46044159);
            Console.WriteLine($"Estudiante: {estudiantito.nombre} \n Legajo: {estudiantito.legajo} \n DNI: {estudiantito.dni}");

            Profesor profesorcito = new Profesor("Base de datos", "Alejo", 345345345);
            Console.WriteLine($"El profesor {profesorcito.nombre} da la materia {profesorcito.materia} y su dni es: {profesorcito.dni} ");
        }
    }
}
