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
    using System.Collections.Generic;
    
    public partial class sarh_Log_Usuario
    {
        public int id_Log_usuarioFamiliarxcentrocosto { get; set; }
        public string fam_NombreCompleto { get; set; }
        public Nullable<int> usce_Idcentro_fk { get; set; }
        public Nullable<decimal> usce_Idusuario_fk { get; set; }
        public Nullable<System.DateTime> usce_fechacreacion { get; set; }
        public Nullable<decimal> usce_Usucreador { get; set; }
    }
}
