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
    
    public partial class Cat_ContentModelAlfresco
    {
        public Cat_ContentModelAlfresco()
        {
            this.Rel_RoleContentModelAlfresco = new HashSet<Rel_RoleContentModelAlfresco>();
        }
    
        public int IdContentModelA { get; set; }
        public string DescripcionContentModel { get; set; }
        public string EtiquetaContentModel { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public bool EstatusRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual ICollection<Rel_RoleContentModelAlfresco> Rel_RoleContentModelAlfresco { get; set; }
    }
}
