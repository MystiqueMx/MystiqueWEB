//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacturacionTDCAPI.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BitacoraPaxFacturacion
    {
        public long idBitacoraPaxFacturacion { get; set; }
        public long comprobanteFiscalId { get; set; }
        public string mensajeRespuesta { get; set; }
        public System.DateTime fechaRegistro { get; set; }
    
        public virtual ComprobanteFiscal ComprobanteFiscal { get; set; }
    }
}