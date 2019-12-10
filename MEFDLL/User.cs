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
    
    public partial class User
    {
        public User()
        {
            this.UserInRole = new HashSet<UserInRole>();
        }
    
        public int IDUser { get; set; }
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string AreaAdscripcion { get; set; }
        public Nullable<System.Guid> IdAreaAdscripcion { get; set; }
        public string Cargo { get; set; }
        public string NumOficioDesignacion { get; set; }
        public string EmailSec { get; set; }
        public string Telefono { get; set; }
        public bool IsADUser { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Deleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastLoginDate { get; set; }
        public System.DateTime LastPasswordChangedDate { get; set; }
        public System.DateTime LastLockoutDate { get; set; }
        public int FailedPasswordAttemptCount { get; set; }
        public System.DateTime FailedPasswordAttemptWindowStart { get; set; }
        public string Comment { get; set; }
        public Nullable<int> IdInstitucion { get; set; }
        public Nullable<int> IdSector { get; set; }
        public string Domicilio { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string OtraInstitucion { get; set; }
        public Nullable<bool> flag { get; set; }
        public string IdGenero { get; set; }
        public Nullable<int> FK_IdTipoPersona { get; set; }
        public Nullable<bool> NotificacionEmail { get; set; }
        public Nullable<int> FK_IdUserJefe { get; set; }
        public string RazonSocial { get; set; }
        public Nullable<int> IdCatTipoProcedencia { get; set; }
        public Nullable<int> IdPais { get; set; }
    
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual ICollection<UserInRole> UserInRole { get; set; }
    }
}
