//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica1.CosolApp1JABM.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbPais
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbPais()
        {
            this.tbViaje = new HashSet<tbViaje>();
        }
    
        public int idPais { get; set; }
        public string nombrePais { get; set; }
        public string codigoPais { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbViaje> tbViaje { get; set; }
    }
}