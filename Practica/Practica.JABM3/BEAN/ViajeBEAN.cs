using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.JABM3.BEAN
{
    public class ViajeBEAN
    {
        public int IdViaje { get; set; }
        public int IdTarjeta { get; set; }
        public string TipoTarj { get; set; }
        public string numTarjeta{get;set;}
        public int IdPais { get; set; }
        public string nombrePais { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
      //  public String EstadoViaje { get; set; }
    }
}
