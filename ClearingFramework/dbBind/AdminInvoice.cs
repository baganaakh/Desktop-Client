namespace ClearingFramework.dbBind
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdminInvoice
    {
        [Key]
        public long id { get; set; }

        public int memberid{ get; set; }

        public long? boardid { get; set; }

        public long? dealno { get; set; }

        public short? side { get; set; }

        public long? accountid { get; set; }

        public long? assetid { get; set; }

        public short? dealType { get; set; }

        public int? qty { get; set; }

        public decimal? totalPrice { get; set; }

        public short? state { get; set; }

        public decimal? fee { get; set; }

        public DateTime? modified { get; set; }

        [Column(TypeName = "date")]
        public DateTime? invoicedate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expiredate { get; set; }

        public TimeSpan? expiretime { get; set; }
    }
}
