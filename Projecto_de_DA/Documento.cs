//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projecto_de_DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Documento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public System.DateTime DataEntrega { get; set; }
        public int TipoDocumentoId { get; set; }
        public int ProjetoId { get; set; }
        public int ProjetoProcessoId { get; set; }
        public int ParecerNumero { get; set; }
    
        public virtual TipoDocumento TipoDocumento { get; set; }
        public virtual Projeto Projeto { get; set; }
    }
}
