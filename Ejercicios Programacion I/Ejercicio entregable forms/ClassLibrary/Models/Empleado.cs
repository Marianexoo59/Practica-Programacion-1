using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int IdDepartamento { get; set; }
        public int Salario { get; set; }
        public Departamento Departamento { get; set; }
        public Empleado(int id, string nombre, string email, int idDepartamento, int salario)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            IdDepartamento = idDepartamento;
            Salario = salario;
        }
    }
}
