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
    
    public partial class ClanarinaIgraca
    {
        public int id_clanarine { get; set; }
        public int id_igraca { get; set; }
        public string uplaceno { get; set; }
    
        public virtual Clanarina Clanarina { get; set; }
        public virtual Igrac Igrac { get; set; }
    }
}
