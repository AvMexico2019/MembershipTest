//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEFDLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BitacoraError
    {
        public int IdBitacoraError { get; set; }
        public string Mensaje { get; set; }
        public bool EsError { get; set; }
        public bool EstatusRegistro { get; set; }
        public Nullable<int> Fk_IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    }
}
