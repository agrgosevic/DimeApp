//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dime
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clanarina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clanarina()
        {
            this.ClanarineIgraca = new HashSet<ClanarinaIgraca>();
        }
    
        public int id_clanarina { get; set; }
        public int mjesec { get; set; }
        public System.DateTime rok_uplate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClanarinaIgraca> ClanarineIgraca { get; set; }
    }
}