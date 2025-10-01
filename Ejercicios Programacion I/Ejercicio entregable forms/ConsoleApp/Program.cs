using ClassLibrary.Models;
using ClassLibrary.Repository;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Departamento> departamentos = DepartamentoRepository.ObtenerDepartamento();
            List<Empleado> empleados = EmpleadoRepository.ObtenerDepartamento();

            bool salir = false;
            while (!salir)
                Console.WriteLine("Elija la opcion: ");
            Console.WriteLine("1. Registrar nuevo empleado ");
            Console.WriteLine("2. Actualizar salario de empleado ");
            Console.WriteLine("3. Eliminar empleado ");
            Console.WriteLine("4. Registrar nuevo departamento ");
            Console.WriteLine("5. Ver estadisticas de empleados");
            Console.WriteLine("6. Salir");
            string eleccion = Console.ReadLine();

            switch (eleccion)
            {
                case "1":
                    {
                        Console.WriteLine("Ingrese el nombre del empleado: ");
                        string nomb = Console.ReadLine();
                       
                        Console.WriteLine("Ingrese el mail del empleado: ");
                        string mail = Console.ReadLine();
                        
                        bool existe = EmpleadoRepository.CorroborarMial(mail);

                        if(existe)
                            Console.WriteLine("Este Email ya existe");
                        else
                        {
                            Console.WriteLine("Ingrese el departamento del empleado: ");
                            int iddepto = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el salario del empleado: ");
                            int salario = int.Parse(Console.ReadLine());

                            Empleado empleado = new Empleado(0000, nomb, mail, iddepto, salario)
                            {
                                Id = 0000,
                                Nombre = nomb,
                                Email = mail,
                                IdDepartamento = iddepto,
                                Salario = salario
                            };
                            EmpleadoRepository.GuardarEmpleado(empleado);
                            Console.WriteLine("Empleado guardado con exito!");
                        }
                            break;
                    }
                case "2":
                    {
                        Console.WriteLine("Ingrese email del epleado a actualizar salario: ");
                        string mailsito = Console.ReadLine();

                        bool existe = empleados.Any(e => e.Email == mailsito);

                        if (existe)
                        {
                            Console.WriteLine("Ingrese el nuevo salario del empleado con ese email: ");
                            decimal nuevoSalario;

                            while (!decimal.TryParse(Console.ReadLine(), out nuevoSalario) || nuevoSalario < 0)
                            {
                                Console.WriteLine("Ingrese un salario valido");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No existe un empleado con ese mail");
                        }
                            break;
                    }

                    case "3":
                    {
                        Console.WriteLine("Ingrese el email del empleado");
                        string emailsito = Console.ReadLine();

                        bool existe = empleados.Any(e => e.Email == emailsito);

                        if (existe)
                        {
                            Console.WriteLine("Desea eliminar a este empleado de la base de datos? S/N ");
                            string eleccionE = Console.ReadLine();

                            if(eleccionE == "S")
                            {
                                EmpleadoRepository repo = new EmpleadoRepository();
                                repo.EliminarEmpleado(emailsito);
                            }
                        }
                        break;
                    }
                    case "4":
                    {
                        Console.WriteLine("Ingrese el nombre para su departamento: ");
                        string nomb = Console.ReadLine();

                        bool existe = DepartamentoRepository.CorroborarNombre(nomb);

                        if (existe)
                            Console.WriteLine("Este nombre esta ocupado");
                        else
                        {
                            Console.WriteLine("Ingrese el id del departamento: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la descripcion del departamento ");
                            string desc = (Console.ReadLine());

                            Departamento depto = new Departamento(id, nomb, desc)
                            {
                                Id = id,
                                Nombre = nomb,
                                Descripcion = desc
                            };
                            DepartamentoRepository.GuardarDepartamento(depto);
                            Console.WriteLine("Departamento guardado con exito!");
                        }
                        break;
                    }
                    case "5":
                    {
                        Console.WriteLine("Que opcion desea usar?: ");
                        Console.WriteLine("1. Total de empleados registrados");
                        Console.WriteLine("2. Promedio de salarios generales");
                        Console.WriteLine("3, Salarios maximos y minimos");
                        Console.WriteLine("4. Cantidad de empleados por departamento");
                        Console.WriteLine("5. Todas las anteriores");

                        string eletsion = Console.ReadLine();

                        switch (eletsion)
                        {
                            case "1":
                                {
                                    int totalEmpleados = EmpleadoRepository.ContarEmpleados();
                                    Console.WriteLine($"El total de empleados reigstrador es de: {totalEmpleados}");
                                    break;
                                }
                            case "2":
                                {
                                    double prom = EmpleadoRepository.PromedioSalarios();
                                    Console.WriteLine($"El promedio de los salarios es: {prom}");
                                    break;
                                }
                            case "3":
                                {
                                    EmpleadoRepository.MaxMinSalarios();
                                    break;
                                }
                            case "4":
                                {
                                    DepartamentoRepository repo = new DepartamentoRepository();
                                    repo.EmpleadosxDepto();
                                    break;
                                }
                            case "5":
                                int totalEmple = EmpleadoRepository.ContarEmpleados();
                                Console.WriteLine($"El total de empleados reigstrador es de: {totalEmple}");

                                double prome = EmpleadoRepository.PromedioSalarios();
                                Console.WriteLine($"El promedio de los salarios es: {prome}");
                                EmpleadoRepository.MaxMinSalarios();

                                DepartamentoRepository repoo = new DepartamentoRepository();
                                repoo.EmpleadosxDepto();
                                break;
                        }
                        break;
                    }
                    case "6":
                    {
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    }
            }
            
        }
        }
    }

