//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBoxSale.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIOROLES
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> RolId { get; set; }
        public Nullable<bool> Activo { get; set; }
    
        public virtual ROLES ROLES { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
