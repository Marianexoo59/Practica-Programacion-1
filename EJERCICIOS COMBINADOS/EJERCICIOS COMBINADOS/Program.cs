namespace EJERCICIOS_COMBINADOS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EJERCICIO GENERADOR DE NUMEROSPRIMOS
            Console.WriteLine("Ingrese un numero para establecer el limite");
            int limite = int.Parse(Console.ReadLine());

            for(int i = 2; i < limite; i++)
            {
                while(i % 1 == 0 && i % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
