using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_JABM
{
    [Table("tbViaje")]
    public class Viaje
    {
        [Key]
        public int IdViaje { get; set; }
        [Required]
        public DateTime FechaInicioViaje { get; set; }
        [Required]
        public DateTime FechaFinViaje { get; set; }
        [StringLength(1)]
        public String EstadoViaje { get; set; }

        public int IdTarjeta { get; set; }
        public int IdPais { get; set; }

    }
}
