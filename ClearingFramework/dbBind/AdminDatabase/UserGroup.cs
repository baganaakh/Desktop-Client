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
    
    public partial class UserGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public long manager { get; set; }
        public short state { get; set; }
        public System.DateTime modified { get; set; }
    }
}