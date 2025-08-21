using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuracion_de_EF
{
    public class TarjetaCredito
    {
        public int id { get; set; }
        public string numeroTarjeta {  get; set; }
        public float limiteCredito { get; set; }
        public float saldoActual { get; set; }
        public Cliente clienteTC { get; set; }
        public EstadoTarjeta estado {  get; set; }

        public enum EstadoTarjeta
        {
            Activa,
            Pausada,
            Bloqueada
        }
    }
}
