namespace Biblioteca_de_clases
{
    public class LibroDigital : Libro
    {
        public override bool Disponible
        {
            get { return true; } // siempre disponible
            set { } // no hace nada
        }

        public LibroDigital(string titulo, string autor, int isbn) : base(titulo, autor, isbn)
        {
        }
    }
}
