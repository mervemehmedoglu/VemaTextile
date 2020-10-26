using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class FaturaBilgileri
    {
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(57)]
        public string EvrakNO { set; get; }

        public DateTime Tarih { set; get; }

        [Column(TypeName = "nvarchar")]
        public string CHKKodu { set; get; }

        [Column(TypeName = "nvarchar")]
        public string CHKAdi { set; get; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Tıp { set; get; }

        [Column(TypeName = "money")]
        public decimal Tutar { set; get; }

        [Column(TypeName = "money")]
        public decimal Oran { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string DovizTL{ set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi { set; get; }

        [Column(TypeName = "money")]
        public decimal DovizKuru { set; get; }

        [Column(TypeName = "money")]
        public decimal DovizTutar { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod1 { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod2 { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod3 { set; get; }

        [Column(TypeName = "money")]
        public string Kod4 { set; get; }

        [Column(TypeName = "money")]
        public string Kod5 { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TeslimAdres1 { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TeslimAdres2 { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TeslimAdres3 { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama1 { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama2 { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string KDVHesaplama { set; get; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string KaynakEvrakTipi { set; get; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { set; get; }
    }
}