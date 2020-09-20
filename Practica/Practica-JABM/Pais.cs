using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_JABM
{
    [Table("tbPais")]
  public   class Pais
    {
        [Key]
        public int IdPais { get; set; }
        [StringLength(50)]
        public string NombrePais { get; set; }
        [StringLength(50)]
        public string CodigoPais  { get; set; }
        public List<Viaje> viaje { get; set; }
    }
}
