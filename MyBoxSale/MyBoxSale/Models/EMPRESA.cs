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
    using System.ComponentModel.DataAnnotations;
    
    public partial class EMPRESA
    {
        public EMPRESA()
        {
            this.USUARIO = new HashSet<USUARIO>();
        }
    
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre requerido")]
        public string Nombre { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        [Display(Name = "Direcci�n")]
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Nullable<bool> Activo { get; set; }
    
        public virtual ICollection<USUARIO> USUARIO { get; set; }
    }
}
