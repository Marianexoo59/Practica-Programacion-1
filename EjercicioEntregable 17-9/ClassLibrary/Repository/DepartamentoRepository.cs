using ClassLibrary.Data;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repository
{
    public class DepartamentoRepository
    {
        public static List<Departamento> departamentos = new List<Departamento>();

        public static void GuardarDepartamento(Departamento departamento)
        {
            using var context = new AplicationDbContext();
            context.departamentos.Add(departamento);

            context.SaveChanges();
        }

        public static List<Departamento> ObtenerDepartamento()
        {
            using var context = new AplicationDbContext();
            return context.departamentos.ToList();
        }

        public static bool CorroborarNombre(string Nombre)
        {
            using var contexto = new AplicationDbContext();
            return contexto.departamentos.Any(v => v.Nombre == Nombre);
        }

        public void EmpleadosxDepto()
        {
            using var context = new AplicationDbContext();

            var empleadosxdepto = context.empleados
                .GroupBy(e => e.Departamento.Nombre)
                . Select (g => new
                {
                    Departamento = g.Key,
                    Cantidad = g.Count()
                })
                .ToList();

            foreach(var objeto in empleadosxdepto)
            {
                Console.WriteLine($"Departamento: {objeto.Departamento} - Empleados: {objeto.Cantidad}");
            }
        }
    }
}
