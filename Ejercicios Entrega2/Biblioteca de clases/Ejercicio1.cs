namespace Biblioteca_de_clases
{
    public interface IMetodoDePago
    {
        public void Pagar(decimal monto);
    }
    public class TarjetaCredito : IMetodoDePago
    {
        public void Pagar(decimal monto)
        {
            decimal recargo = 5;
            decimal totalrecargo = (monto * recargo) + monto;
            Console.WriteLine($"El pago se esta haceindo con tarejta bancaria y el monto es: ${totalrecargo}");
        }
    }
    public class TransferenciaBancaria : IMetodoDePago
    {
        public void Pagar(decimal monto)
        {
            Console.WriteLine($"El pago se esta haceindo con tarejta bancaria y el monto es: ${monto} sin recargo");
        }
    }
}
