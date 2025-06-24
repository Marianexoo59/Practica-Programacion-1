namespace Ejercicio_para_subir_a_github
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

            while (nombre == "")
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
            }
            while (cantidad_calificaciones < 5)
            {
                Console.WriteLine("Ingrese la calificación");
                calificacion = int.Parse(Console.ReadLine());
                if (calificacion >= 1 && calificacion <= 10)
                {
                    suma_calificacion += calificacion;
                    cantidad_calificaciones++;
                }
                else
                {
                    Console.WriteLine("La calificación debe estar entre 1 y 10.");
                }
            }
            promedio = suma_calificacion / cantidad_calificaciones;
            if (promedio >= 9)
            {
                clasificacion = ("Excelente");
            }
            else if (promedio >= 7 && promedio < 9)
            {
                clasificacion = ("Bueno");
            }
            else if (promedio >= 6 && promedio < 7)
            {
                clasificacion = ("Regular");
            }
            else
            {
                clasificacion = ("Reprobado");
            }

            Console.WriteLine($"El promedio de  {nombre}   es:  {promedio} y sus clasificacion es: {clasificacion}");
        }
    }
}
