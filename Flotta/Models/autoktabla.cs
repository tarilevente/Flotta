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
    
    public partial class autoktabla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public autoktabla()
        {
            this.muszakiallapottabla = new HashSet<muszakiallapottabla>();
            this.szervizkonyvtabla = new HashSet<szervizkonyvtabla>();
            this.soforautojatabla = new HashSet<soforautojatabla>();
        }
    
        public string rendszam { get; set; }
        public string alvazszam { get; set; }
        public Nullable<int> km { get; set; }
        public Nullable<sbyte> autoradio { get; set; }
        public Nullable<sbyte> vontatokotel { get; set; }
        public Nullable<sbyte> bikakabel { get; set; }
        public Nullable<sbyte> mentodoboz { get; set; }
        public string gyartmany { get; set; }
        public string tipus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<muszakiallapottabla> muszakiallapottabla { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<szervizkonyvtabla> szervizkonyvtabla { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<soforautojatabla> soforautojatabla { get; set; }
    }
}
