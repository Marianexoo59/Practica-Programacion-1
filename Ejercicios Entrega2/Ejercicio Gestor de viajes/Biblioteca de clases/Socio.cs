namespace Biblioteca_de_clases
{
    public class Socio
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }

        public Socio(string nombre, int dni)
        {
            Nombre = nombre;
            DNI = dni;
        }

        public void MostrarSocio()
        {
            Console.WriteLine($"Nombre: {Nombre}, DNI: {DNI}");
        }
    }
}
