//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearingFramework.dbBind
{
    using System;
    using System.Collections.Generic;
    
    public partial class Margin
    {
        public int id { get; set; }
        public decimal buy { get; set; }
        public decimal sell { get; set; }
        public short buytype { get; set; }
        public short selltype { get; set; }
        public System.DateTime modified { get; set; }
        public decimal mbuy { get; set; }
        public decimal msell { get; set; }
        public long coid { get; set; }
    }
}
