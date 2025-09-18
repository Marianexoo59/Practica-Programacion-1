using ClassLibrary.Data;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repository
{
    public class EmpleadoRepository
    {
        public static List<Empleado> empleados = new List<Empleado>();

        public static List<Empleado> ObtenerDepartamento()
        {
            using var context = new AplicationDbContext();
            return context.empleados.ToList();
        }

        public static void GuardarEmpleado(Empleado empleado)
        {
            using var context = new AplicationDbContext();
            context.empleados.Add(empleado);
        }

        public static bool CorroborarMial(string Email)
        {
            using var contexto = new AplicationDbContext();
            return contexto.empleados.Any(v => v.Email == Email);
        }

        public void EliminarEmpleado(string Email)
        {
            using var context = new AplicationDbContext();

            var emp = context.empleados.FirstOrDefault(v => v.Email == Email);

            if (emp != null)
            {
                context.empleados.Remove(emp);
                context.SaveChanges();
                Console.WriteLine("Empelado eliminado correctamente");
            }
            else
            {
                Console.WriteLine("No se encontro ningun empleado con ese mail");
            }
        }

        public static int ContarEmpleados()
        {
            using var context = new AplicationDbContext();
            return context.empleados.Count();
        }
        public static double PromedioSalarios()
        {
            using var context = new AplicationDbContext();
            if (context.empleados.Any())
                return context.empleados.Average(e => e.Salario);
            else
                return 0;
        }

        public static void MaxMinSalarios()
        {
            using var context = new AplicationDbContext();

            if (context.empleados.Any())
            {
                decimal SalarioMin = context.empleados.Min(e => e.Salario);
                decimal SalarioMax = context.empleados.Max(e => e.Salario);


                Console.WriteLine($"El salario maximo es: {SalarioMax}");
                Console.WriteLine($"El salario minimo es: {SalarioMin}");
            }
            else
            {
                Console.WriteLine("No hay empleados registrados");
            }
        }
    }
}
