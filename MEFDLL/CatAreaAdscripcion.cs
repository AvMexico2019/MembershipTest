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
    
    public partial class CatAreaAdscripcion
    {
        public CatAreaAdscripcion()
        {
            this.User = new HashSet<User>();
        }
    
        public System.Guid IntIdAreaAdscripcion { get; set; }
        public string FDVcNombre { get; set; }
        public string FDVcDescripcion { get; set; }
        public Nullable<byte> FDBoActivo { get; set; }
    
        public virtual ICollection<User> User { get; set; }
    }
}
