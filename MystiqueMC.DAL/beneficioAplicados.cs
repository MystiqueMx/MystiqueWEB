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
    
    public partial class beneficioAplicados
    {
        public int idBeneficioAplicado { get; set; }
        public Nullable<int> clienteId { get; set; }
        public int beneficioId { get; set; }
        public int sucursalId { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public Nullable<int> membresiaId { get; set; }
        public string folioCompra { get; set; }
        public Nullable<System.DateTime> fechaCompra { get; set; }
        public Nullable<decimal> montoCompra { get; set; }
    
        public virtual beneficios beneficios { get; set; }
        public virtual membresias membresias { get; set; }
        public virtual sucursales sucursales { get; set; }
        public virtual clientes clientes { get; set; }
    }
}