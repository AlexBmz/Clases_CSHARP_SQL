using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_JABM
{
    [Table("tbCliente")]
   public  class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [StringLength (50)]
        public string NombreCliente { get; set; }
        [StringLength(50)]
        public string ApellidoCliente { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [StringLength(10)]
        public string Dni { get; set; }

        public List<Tarjeta> tarjeta { get; set; }

    }
}
