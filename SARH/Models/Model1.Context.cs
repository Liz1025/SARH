//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SARH.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bdcmp_ccam_sisadmEntities : DbContext
    {
        public bdcmp_ccam_sisadmEntities()
            : base("name=bdcmp_ccam_sisadmEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Sarh_CentroCostoxUsurio> Sarh_CentroCostoxUsurio { get; set; }
        public virtual DbSet<Sarh_familiarxusuario> Sarh_familiarxusuario { get; set; }
        public virtual DbSet<sarh_Log_Usuario> sarh_Log_Usuario { get; set; }
        public virtual DbSet<Sarh_usuario> Sarh_usuario { get; set; }
    }
}
