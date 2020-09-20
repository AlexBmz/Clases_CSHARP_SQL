using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.CosolApp1JABM
{
   public  class RegistroTarjCli
    {
        public int IdTarjeta { get; set; }
        public string NumeroTarjeta { get; set; }
        public string TipoTarjeta { get; set; }
        public string  ModoPago { get; set; }
        public string FechaVenc { get; set; }
        public string NombreCliente { get; set; }
    }
}
