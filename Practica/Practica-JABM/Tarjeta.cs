using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_JABM
{
    [Table("tbTarjeta")]
    public class Tarjeta
    {
        [Key]
        public int IdTarjeta { get; set; }
        [StringLength(30)]
        public string NumeroTarjeta { get; set; }
        [StringLength(20)]
        public string TipoTarjeta { get; set; }
        [StringLength(20)]
        public string ModoPago { get; set; }
        [StringLength(10)]
        public string FechaVencimiento { get; set; }
        public int IdCliente { get; set; }

        public List<Viaje> viaje { get; set; }
    }
}
