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
    
    public partial class Request
    {
        public long id { get; set; }
        public string account { get; set; }
        public Nullable<decimal> balance { get; set; }
        public Nullable<decimal> remain { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> pendingDay { get; set; }
    }
}