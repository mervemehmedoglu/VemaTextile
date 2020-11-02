using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class TaahhutPrimTakibi
    {
        public DateTime Tarih { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal IdNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string FaturaTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string FaturaNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string FaturaTarihi { get; set; }



    }
}