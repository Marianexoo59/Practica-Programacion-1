using System;
using System.Collections.Generic;

namespace Biblioteca_de_clases
{
    public abstract class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
        public List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        public Libro(string titulo, string autor, int isbn)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
        }

        public abstract bool Disponible { get; set; }

        public void MostrarLibro()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Préstamos: {Prestamos.Count}, Disponible: {Disponible}");
        }
    }
}
