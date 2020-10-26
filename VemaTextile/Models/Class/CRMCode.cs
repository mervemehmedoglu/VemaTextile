using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class CRMCode
    {
        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Id { set; get; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(10,0)")]
        public decimal KategoriId { set; get; }
  
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string Aciklama{ set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(400)]
        public string Aciklama2 { set; get; }

        [Column(TypeName = "smallint")]
        public int KodTipi { set; get; }

        [Column(TypeName = "decimal(10,0)")]
        public decimal SiraNo { set; get; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { set; get; }
    }
}