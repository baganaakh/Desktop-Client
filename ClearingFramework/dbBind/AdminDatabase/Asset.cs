//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearingFramework.dbBind.AdminDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asset
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public int volume { get; set; }
        public string note { get; set; }
        public System.DateTime expireDate { get; set; }
        public short state { get; set; }
        public System.DateTime modified { get; set; }
        public decimal ratio { get; set; }
        public Nullable<decimal> price { get; set; }
    }
}
