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
    
    public partial class CatBitacoraAccion
    {
        public CatBitacoraAccion()
        {
            this.Bitacora = new HashSet<Bitacora>();
        }
    
        public byte idCatBitacoraAccion { get; set; }
        public string nbAccion { get; set; }
    
        public virtual ICollection<Bitacora> Bitacora { get; set; }
    }
}
