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
    
    public partial class Setting
    {
        public int ID { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public string SettingCaption { get; set; }
        public int SortOrder { get; set; }
        public byte ReadOnly { get; set; }
        public string ValueType { get; set; }
        public string FormatString { get; set; }
    }
}
