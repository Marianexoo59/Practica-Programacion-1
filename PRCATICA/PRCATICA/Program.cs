using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Threading.Channels;

namespace PRCATICA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //             EJERCICIO 1  int edad = Int32.Parse(Console.ReadLine());
            //             if (edad < 18)
            //             {
            //                 Console.WriteLine("Eres menor de edad no puedes votar");
            //             }
            //             else if (edad > 70)
            //             {
            //                 Console.WriteLine("Puedes votar pero no es obligatorio");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("Puedes votar"); 

            //            EJERCICIO 2int numero = int.Parse(Console.ReadLine());
            //if (numero > 0)
            //    if (numero > 100)
            //        Console.WriteLine("Es positivo y grande");
            //    else if (numero < 0)
            //        Console.WriteLine("Es negativo");
            //    else
            //        Console.WriteLine("Es cero");
            //EJERCICIO 3
            //Console.WriteLine("Ingrese el monto de su compra");

            //int compra = int.Parse(Console.ReadLine());
            //decimal descuento = 0m;

            //if (compra > 100 && compra < 500)
            //{
            //    descuento = compra * 0.1m;
            //}
            //else if (compra >= 500)
            //{
            //    descuento = compra * 0.2m;
            //}
            //decimal preciofinal = compra - descuento;

            //Console.WriteLine($"El monto final dela compra es {preciofinal}");

            //           EJERCICIO 4 

            //           for (int i = 1; i < 11; i ++)
            //            {
            //                Console.WriteLine(i);
            //            }       */

            //             EJERCICIO 5 
            //            int suma = 0;
            //            for (int i = 1; i <= 100; i++) 
            //            {
            //                suma += i;
            //            }

            //            Console.WriteLine($"L suma total es de; {suma}");


            //            EJERCICIO 6 
            //            int multiplicacion = 0;
            //            Console.WriteLine("Ingrese su numero a multiplicar: ");
            //            int numero = int.Parse(Console.ReadLine());
            //            for (int i = 1; i <= 10; i++) 
            //            {
            //                multiplicacion = numero * i;
            //                Console.WriteLine($"El numero multiplicado es {numero} x {i} y el resultado es = {multiplicacion}");
            //            }


            //            EJERCICIO 7 
            //            int suma_numero = 0;
            //            Console.WriteLine("Ingrese su numero: ");
            //            int numero = int.Parse(Console.ReadLine());
            //            while (numero > 0)
            //            {
            //                suma_numero += numero;

            //                Console.WriteLine("Ingrese su numero: ");
            //                numero = int.Parse(Console.ReadLine());
            //            }
            //            Console.WriteLine($"La suma de los numeros es {suma_numero}");


            //            EJERCICIO 8 
            //            int numeros = 0;
            //            Console.WriteLine("Ingresar numero: ");
            //            int numero = int.Parse(Console.ReadLine());
            //            while (numero != 0)
            //            {
            //                numeros += 1;

            //                Console.WriteLine("Intresar numero: ");
            //                numero = int.Parse(Console.ReadLine());
            //            }
            //            Console.WriteLine($"La cantidad de numeros ingresados es; {numeros}");


            //            EJERCICIO 9 
            //            Random random = new Random();
            //            int adivinar = random.Next(1,101);
            //            Console.WriteLine("Adivina el numero entre el 1 y el 100; ");
            //            int numero = int.Parse(Console.ReadLine());
            //            while(adivinar != numero)
            //            {
            //                if (numero < adivinar)
            //                {
            //                    Console.WriteLine("El numero es mayor");  
            //                }
            //                else
            //                {
            //                    Console.WriteLine("El numero es menor");  
            //                }
            //                numero = int.Parse(Console.ReadLine());
            //            }
            //            if (numero == adivinar)
            //                Console.WriteLine("Has adivinado el numero, felicitaciones!");


            //            EJERCICIO 10 
            //for (int i = 0; i <= 50; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //EJERCICIO 11

            //            Console.WriteLine("Ingrese su numero:");
            //int numero = int.Parse(Console.ReadLine());
            //decimal factorial = 1;
            //for (int i = 1; i <= numero; i++)
            //{
            //    factorial *= i;

            //}
            //Console.WriteLine($"El resultado del factorial de {numero} es: {factorial}");

            ////EJERCICIO 12 
            //Console.WriteLine("Ingresar el saldo disponible: ");
            //int saldo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el monto a retirar: ");
            //int retiro = int.Parse(Console.ReadLine());

            //do
            //{
            //    if (retiro > saldo)
            //    {
            //        Console.WriteLine("Saldo insuficiente. No se pudo realizar el retiro, ingrese un monto valido.");
            //    }
            //    else
            //    {
            //        saldo -= retiro;
            //        Console.WriteLine($"Retiro exitoso. Su nuevo saldo es: {saldo}");

            //    }
            //    Console.WriteLine("Desea retirar nuevamente?");
            //    string respuesta = Console.ReadLine();
            //    if (respuesta == "no")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ingrese el monto a retirar: ");
            //        retiro = int.Parse(Console.ReadLine());

            //        if (retiro > saldo)
            //        {
            //            Console.WriteLine("Saldo insuficiente. No se pudo realizar el retiro, ingrese un monto valido: ");
            //        }
            //        else

            //            saldo -= retiro;
            //        Console.WriteLine($"Su saldo restante es: {saldo}");
            //    }

            //} while (saldo > 0);



            //            EJERCICIO 13 
            //            Console.WriteLine("Ingrese un número: ");
            //            int numero = int.Parse(Console.ReadLine());
            //            int contador = 0; 
            //            if (numero == 0)
            //            {
            //                contador = 1; // El número 0 tiene 1 dígito
            //            }
            //            else
            //            {
            //                while (numero > 0)
            //                {
            //                    numero /= 10; 
            //                    contador++;    
            //                }
            //            }
            //            Console.WriteLine($"El número ingresado tiene {contador} dígitos.");



            //EJERCICIO 1 MEZCLA DE SENTENCIAS
            //Console.WriteLine("Ingrese la primera calificacion: ");
            //int calificacion = int.Parse(Console.ReadLine());
            //int cantidad_calificacion = 0;
            //int promedio = 0;
            //int suma = 0;
            //while (calificacion > 0)
            //{
            //    cantidad_calificacion += 1;
            //    Console.WriteLine("Ingrese la siguiente calificacion: ");
            //    calificacion = int.Parse(Console.ReadLine());
            //    suma += calificacion;
            //    promedio = suma / cantidad_calificacion;

            //}
            //promedio = suma / cantidad_calificacion;
            //if (promedio > 90)
            //{
            //    Console.WriteLine($"El promedio es excelente {promedio}");
            //}
            //else if (promedio >= 70 && promedio > 89)
            //{
            //    Console.WriteLine($"El promedio es Bueno {promedio}");
            //}
            //else if (promedio >= 50 && promedio > 69)
            //{
            //    Console.WriteLine($"El promedio es Regular {promedio}");
            //}
            //else if (promedio < 50)
            //{
            //    Console.WriteLine($"El promedio es Deficiente: {promedio}");
            //}
            //else
            //{
            //    Console.WriteLine("No se han ingresado calificaciones");
            //}


            //EJERCICIO 2 Menu de opciones matematicas
            //Console.WriteLine("Ingresar la operacion a usar: suma, resta, multiplicacion o division");

            //string operacion = Console.ReadLine();

            //switch (operacion)
            //{
            //    case "suma":
            //        Console.WriteLine("Ingresar el primer numero a sumar: ");
            //        int numero1 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingresar el primer numero a sumar: ");
            //        int numero2 = int.Parse(Console.ReadLine());
            //        int suma = numero1 + numero2;
            //        Console.WriteLine($"La suma de los numeros es {suma}");
            //        break;

            //    case "resta":
            //        Console.WriteLine("Ingresar el primer numero a restar: ");
            //        int numero3 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingresar el segundo numero a restar: ");
            //        int numero4 = int.Parse(Console.ReadLine());
            //        int resta = numero3 - numero4;
            //        Console.WriteLine($"La resta de los numeros es: {resta}");
            //        break;

            //    case "multiplicacion":
            //        Console.WriteLine("Ingresar el primer numero a multiplicar: ");
            //        int numero5 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingresar el segundo numero a multiplicar: ");
            //        int numero6 = int.Parse(Console.ReadLine());
            //        int multiplicacion = numero5 * numero6;
            //        Console.WriteLine($"El resultado de la multiplicacion es: {multiplicacion}");
            //        break;

            //    case "division":
            //        Console.WriteLine("Ingresar el primer numero a dividir: ");
            //        int numero7 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingresar el segundo numero a dividir: ");
            //        int numero8 = int.Parse(Console.ReadLine());
            //        if (numero8 == 0)
            //        {
            //            Console.WriteLine("No se puede dividir entre cero");
            //        }
            //        else
            //        {
            //            int division = numero7 / numero8;
            //            Console.WriteLine($"El resultado de la division es: {division}");
            //        }
            //        break;
            //}


            //EJERCICIO 3 GENERADOR DE NUMEROSPRIMOS
            //Console.WriteLine("Ingrese un número para establecer el límite");
            //int limite = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= limite; i++)
            //{
            //    int j = 2;
            //    int divisorEncontrado = 0;

            //    while (j < i)
            //    {
            //        if (i % j == 0)
            //        {
            //            divisorEncontrado = 1;
            //            break;
            //        }
            //        j++;
            //    }

            //    if (divisorEncontrado == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //EJERCICIO 4 Simulación de cajero automático con verificación de PIN
            Console.WriteLine("Ingrese el saldo disponible del cajero");
            int saldo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el pin a adivinar");
            string pin = Console.ReadLine();

            Console.WriteLine("Ingrese la adivinanza");
            string adivinanza = Console.ReadLine();

            int deposito = 0;
            int intentos = 3;

            while (adivinanza != pin && intentos > 0)
            {
                intentos -= 1;
                Console.WriteLine($"Pin incorrecto, intente nuevamente, intentos restantes: {intentos}");
                adivinanza = Console.ReadLine();
            }

            if (adivinanza == pin)
            {
                Console.WriteLine("Pin correcto");
                Console.WriteLine("Elija la operación a usar: consultar saldo, depositar, retirar o salir");

                string operaciones = Console.ReadLine();

                while (operaciones != "salir")
                {
                    switch (operaciones)
                    {
                        case "consultar saldo":
                            Console.WriteLine($"Su saldo es de {saldo}");
                            break;

                        case "depositar":
                            Console.WriteLine("Ingrese la cantidad a depositar");
                            deposito = int.Parse(Console.ReadLine());
                            saldo += deposito;
                            Console.WriteLine($"Nuevo saldo: {saldo}");
                            break;

                        case "retirar":
                            Console.WriteLine("Ingrese la cantidad a retirar");
                            int retiro = int.Parse(Console.ReadLine());

                            if (retiro <= saldo)
                            {
                                saldo -= retiro;
                                Console.WriteLine($"Su saldo restante es {saldo}");
                            }
                            else
                            {
                                Console.WriteLine("Fondos insuficientes");
                            }
                            break;

                        case "salir":
                            break;

                        default:
                            Console.WriteLine("Operación no válida");
                            break;
                    }

                    if (operaciones != "salir")
                    {
                        Console.WriteLine("Elija la operación a usar: consultar saldo, depositar, retirar o salir");
                        operaciones = Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Se acabaron los intentos. Tarjeta bloqueada.");
            }

            //EJERCICIO 5 CONVERSOR DE TEMPERATURAS
            //Console.WriteLine("Bienvenido al convertidor de temperaturas");

            //Console.WriteLine("Desea utilizar el conversor de temperaturas? si/no ");
            //string respuesta = Console.ReadLine();
            //while (respuesta != "no")
            //{
            //    Console.WriteLine("Elija que tipo de cambio le gustaria hacer? 1 (farenheit a celcius) 2 (celcius a farenheit)");
            //    string grados = Console.ReadLine();

            //    switch (grados)
            //    {
            //        case "1":
            //            Console.WriteLine("Ingrese la temperatura en grados farenheit: ");
            //            double farenheit = double.Parse(Console.ReadLine());
            //            double celcius = (farenheit - 32) * 5 / 9;
            //            Console.WriteLine($"La temperatura en grados celcius es: {celcius}");
            //            break;

            //        case "2":
            //            Console.WriteLine("Ingrese la temperatura en grados celcius: ");
            //            double celcius2 = double.Parse(Console.ReadLine());
            //            double farenheit2 = (celcius2 * 9 / 5) + 32;
            //            Console.WriteLine($"La temperatura en grados farenheit es: {farenheit2}");
            //            break;



            //    }
            //    Console.WriteLine("Desea volver a utilizar el conversor?");
            //    string respuesta2 = Console.ReadLine();

            //    if (respuesta2 == "no")
            //    {
            //        break;
            //    }

            //}


            // EJERCICIO 6 CALCULO DE FACTORIAL CON CONTROL DE ERRORES
            //Console.WriteLine("Ingrese su numero:");
            //int numero = int.Parse(Console.ReadLine());
            //decimal factorial = 1;

            //while (numero < 0)
            //{
            //    Console.WriteLine("El numero no puede ser negativo, ingrese un numero positivo: ");
            //    numero = int.Parse(Console.ReadLine());
            //}
            //for (int i = 1; i <= numero; i++)
            //{
            //    factorial *= i;

            //}
            //Console.WriteLine($"El resultado del factorial de {numero} es: {factorial}");


            //Console.WriteLine("Desea volver a utilizar el conversor?");
            //string respuesta2 = Console.ReadLine();
            //while (respuesta)
            //    if (respuesta2 == "no")
            //    {
            //        return;
            //    }
        }
    }
           
        
    
}    

  








