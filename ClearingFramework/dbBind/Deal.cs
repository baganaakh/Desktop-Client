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
    
    public partial class Deal
    {
        public long id { get; set; }
        public long boardid { get; set; }
        public long dealno { get; set; }
        public short side { get; set; }
        public int memberid { get; set; }
        public long accountid { get; set; }
        public int assetid { get; set; }
        public decimal qty { get; set; }
        public decimal price { get; set; }
        public decimal totalPrice { get; set; }
        public short state { get; set; }
        public System.DateTime modified { get; set; }
        public Nullable<decimal> fee { get; set; }
        public Nullable<decimal> m2m { get; set; }
        public Nullable<decimal> refPrice { get; set; }
        public Nullable<short> dealType { get; set; }
    }
}
