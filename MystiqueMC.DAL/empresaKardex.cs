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
    
    public partial class empresaKardex
    {
        public int empresaId { get; set; }
        public int brandyId { get; set; }
        public int direccionId { get; set; }
        public int representanteLegalId { get; set; }
    
        public virtual direccion direccion { get; set; }
        public virtual empresaBrandy empresaBrandy { get; set; }
        public virtual empresas empresas { get; set; }
        public virtual representateLegal representateLegal { get; set; }
    }
}