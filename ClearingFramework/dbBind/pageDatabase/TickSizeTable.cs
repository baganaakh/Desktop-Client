//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearingFramework.dbBind.pageDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class TickSizeTable
    {
        public int id { get; set; }
        public long tableid { get; set; }
        public decimal tick { get; set; }
        public decimal price { get; set; }
        public short state { get; set; }
        public System.DateTime modified { get; set; }
        public Nullable<long> timestamp { get; set; }
        public string name { get; set; }
    }
}
