namespace Biblioteca_de_clases
{
    public class LibroFisico : Libro
    {
        public override bool Disponible { get; set; }

        public LibroFisico(string titulo, string autor, int isbn) : base(titulo, autor, isbn)
        {
            Disponible = true; 
        }
    }
}
