﻿namespace ClearingFramework.dbBind
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public long id { get; set; }
        [Required]
        [StringLength(20)]
        public string accNum { get; set; }
        [Required]
        [StringLength(10)]
        public string idNum { get; set; }
        [StringLength(30)]
        public string lname { get; set; }
        [StringLength(30)]
        public string fname { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(50)]
        public string mail { get; set; }

        [StringLength(20)]
        public string linkAcc { get; set; }

        [StringLength(50)]
        public string brokerCode { get; set; }

        public short? state { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime modified { get; set; }
        [StringLength(20)]
        public string secAcc { get; set; }
        public decimal? fee { get; set; }
        public decimal? denchinPercent { get; set; }

        public decimal? contractFee { get; set; }

        public decimal? pozFee { get; set; }

        public int? memId { get; set; }
        public int? bank { get; set; }
        public string bankName { get 
            {
                string bname;
                switch (bank) {
                    case 0: bname = "Банк бус";
                        break;
                    case 1: bname = "Хаан Банк";
                        break;
                    case 2: bname = "ХХБ";
                        break;
                    case 3: bname = "Хас Банк";
                        break;
                    default: bname = "Байхгүй";
                        break;
                }
                return bname;

            } 
        }
        public string bankAccName { get; set; }
        public string bankAccount { get; set; }

    }
}
