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
    
    public partial class Board
    {
        public short id { get; set; }
        public string name { get; set; }
        public short type { get; set; }
        public string tdays { get; set; }
        public short state { get; set; }
        public System.DateTime modified { get; set; }
        public string description { get; set; }
        public Nullable<short> dealType { get; set; }
        public Nullable<System.TimeSpan> expTime { get; set; }
        public Nullable<short> expDate { get; set; }
    
        public virtual Board Boards1 { get; set; }
        public virtual Board Board1 { get; set; }
    }
}
