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
    
    public partial class felhtabla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public felhtabla()
        {
            this.soforautojatabla = new HashSet<soforautojatabla>();
        }
    
        public int idFelh { get; set; }
        public string vezetekNev { get; set; }
        public string keresztNev { get; set; }
        public string varos { get; set; }
        public string utcaHsz { get; set; }
        public string telefon { get; set; }
        public string belepesNev { get; set; }
        public string belepesJelszo { get; set; }
        public sbyte soforE { get; set; }
        public sbyte adminE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<soforautojatabla> soforautojatabla { get; set; }
    }
}
