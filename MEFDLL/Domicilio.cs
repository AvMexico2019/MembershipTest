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
    
    public partial class Domicilio
    {
        public Domicilio()
        {
            this.Rel_UserDomicilio = new HashSet<Rel_UserDomicilio>();
        }
    
        public int IdDomicilio { get; set; }
        public string Calle { get; set; }
        public string NumeroExterior { get; set; }
        public string NumeroInterior { get; set; }
        public Nullable<int> IdCP { get; set; }
        public string CP { get; set; }
        public Nullable<int> IdLocalidad { get; set; }
        public string Localidad { get; set; }
        public Nullable<int> IdColonia { get; set; }
        public string Colonia { get; set; }
        public int IdPais { get; set; }
        public int IdEstado { get; set; }
        public int IdMunicipio { get; set; }
        public string Referencias { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<System.DateTime> FechaUltimoCambio { get; set; }
        public bool EstatusRegistro { get; set; }
        public bool RegistroValidado { get; set; }
    
        public virtual ICollection<Rel_UserDomicilio> Rel_UserDomicilio { get; set; }
    }
}