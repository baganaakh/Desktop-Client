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
    
    public partial class Security
    {
        public int id { get; set; }
        public int partid { get; set; }
        public short type { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string refno { get; set; }
        public string regno { get; set; }
        public decimal totalQty { get; set; }
        public decimal firstPrice { get; set; }
        public decimal intRate { get; set; }
        public System.DateTime sdate { get; set; }
        public System.DateTime edate { get; set; }
        public int groupId { get; set; }
        public short state { get; set; }
        public System.DateTime modified { get; set; }
    }
}
