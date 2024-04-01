//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MystiqueMC.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ventas()
        {
            this.Arqueo = new HashSet<Arqueo>();
            this.Aperturas = new HashSet<Aperturas>();
        }
    
        public int idVenta { get; set; }
        public int ventaIdSucursal { get; set; }
        public int sucursalId { get; set; }
        public bool activo { get; set; }
        public System.DateTime fechaRegistroVenta { get; set; }
        public System.DateTime fechaInicial { get; set; }
        public Nullable<System.DateTime> fechaFinal { get; set; }
        public string uuidVenta { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public Nullable<int> folio { get; set; }
        public bool afectoInventario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arqueo> Arqueo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aperturas> Aperturas { get; set; }
        public virtual sucursales sucursales { get; set; }
    }
}