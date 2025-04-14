namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad_calificaciones = 0;
            int suma_calificacion = 0;
            int calificacion = 0;
            int promedio = 0;
            string nombre = "";
            string clasificacion = "";

            Console.WriteLine("Ingrese el nombre del estudiante:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de notas del estudiante: ");
            int notas = int.Parse(Console.ReadLine());

            while (nombre == "")
            {
                Console.WriteLine("Nombre invalido, ingreselo nuevamente: ");
                nombre = Console.ReadLine();
            }
            while(notas < 1 || notas > 5)
            {
                Console.WriteLine("Cantidad de notas invalida, ingresela nuevamente: ");
                notas = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < notas; i++)
            {
                Console.WriteLine($"Ingrese la calificación {i + 1} (entre 1 y 10):");
                calificacion = int.Parse(Console.ReadLine());

                while (calificacion < 1 || calificacion > 10)
                {
                    Console.WriteLine("Calificación invalida, ingresela nuevamente: ");
                    calificacion = int.Parse(Console.ReadLine());
                }

                suma_calificacion += calificacion;
                cantidad_calificaciones++;
            }
            promedio = suma_calificacion / cantidad_calificaciones;

            if (promedio >= 9)
            {
                clasificacion = "Excelente";
            }
            else if (promedio >= 7)
            {
                clasificacion = "Bueno";
            }
            else if (promedio >= 6)
            {
                clasificacion = "Regular";
            }
            else
            {
                clasificacion = "Reprobado";
            }

            Console.WriteLine($"El promedio de {nombre} es: {promedio} y su clasificación es: {clasificacion}");
        }
         
    }
}
