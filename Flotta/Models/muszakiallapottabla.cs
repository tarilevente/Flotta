//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flotta.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class muszakiallapottabla
    {
        public int idmuszakiAllapot { get; set; }
        public string rendszamHOZ { get; set; }
        public sbyte matricaMegyei { get; set; }
        public sbyte matricaOrszagos { get; set; }
        public sbyte teligumi { get; set; }
        public sbyte nyarigumi { get; set; }
        public System.DateTime muszakiErv { get; set; }
        public System.DateTime biztosErv { get; set; }
        public System.DateTime evjarat { get; set; }
    
        public virtual autoktabla autoktabla { get; set; }
    }
}
