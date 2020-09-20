using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_JABM
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext() : base("conneBD")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Tarjeta> Tarjeta { get; set; }
        public DbSet<Viaje> Viaje { get; set; }
        public DbSet<Pais> Pais { get; set; }
         
        
    }
}
