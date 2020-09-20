using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.JABM3.BEAN
{
   public  class TarjetaBEAN
    {
        public int IdTarjeta { get; set; }
     
        public string NumeroTarjeta { get; set; }
     
        public string TipoTarjeta { get; set; }
       
        public string ModoPago { get; set; }
    
        public string FechaVencimiento { get; set; }
        public int IdCliente { get; set; }

    }
}
