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
    
    public partial class TreningPrisustvo
    {
        public int id_treninga { get; set; }
        public int id_igraca { get; set; }
        public string prisustvo { get; set; }
    
        public virtual Igrac Igrac { get; set; }
        public virtual Trening Trening { get; set; }
    }
}
