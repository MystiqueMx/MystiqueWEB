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
    
    public partial class Descuentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Descuentos()
        {
            this.SucursalDescuentos = new HashSet<SucursalDescuentos>();
            this.TicketDescuentos = new HashSet<TicketDescuentos>();
        }
    
        public int idDescuento { get; set; }
        public int comercioId { get; set; }
        public string nombre { get; set; }
        public bool activo { get; set; }
        public int usuarioRegistroId { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaFin { get; set; }
        public decimal montoporcentaje { get; set; }
        public System.TimeSpan horaInicio { get; set; }
        public System.TimeSpan horaFin { get; set; }
        public bool lunes { get; set; }
        public bool martes { get; set; }
        public bool miercoles { get; set; }
        public bool jueves { get; set; }
        public bool viernes { get; set; }
        public bool sabado { get; set; }
        public bool domingo { get; set; }
        public Nullable<int> productoId { get; set; }
        public Nullable<bool> isPorcentaje { get; set; }
        public Nullable<decimal> porcentaje { get; set; }
        public Nullable<int> beneficioId { get; set; }
    
        public virtual beneficios beneficios { get; set; }
        public virtual comercios comercios { get; set; }
        public virtual usuarios usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SucursalDescuentos> SucursalDescuentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketDescuentos> TicketDescuentos { get; set; }
        public virtual Productos Productos { get; set; }
    }
}