//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlotaTaxisApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conductores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conductores()
        {
            this.Viajes = new HashSet<Viajes>();
        }
    
        public int ID_Conductor { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> ID_Taxi { get; set; }
    
        public virtual Taxis Taxis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viajes> Viajes { get; set; }
    }
}
