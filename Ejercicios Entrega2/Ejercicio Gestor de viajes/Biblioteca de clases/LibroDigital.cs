namespace Biblioteca_de_clases
{
    public class LibroDigital : Libro
    {
        public override bool Disponible { get;  set; }

        public LibroDigital(string titulo, string autor, int isbn) : base(titulo, autor, isbn)
        {
            Disponible = true;
        }
    }
}
