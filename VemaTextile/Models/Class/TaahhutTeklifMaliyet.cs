﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class TaahhutTeklifMaliyet
    {
        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string MalKodu { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string MalAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string Barkod { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }

        [Key]
        [Required]
        public DateTime Tarih { get; set; }

        public DateTime SevkTarihi { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string Seri { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public Decimal IdNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string IrsaliyeNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string SiparisNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IslemTipi { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IslemTuru { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CHKKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string CHKAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Birim { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Birim1 { get; set; }

        [Column(TypeName = "money")]
        public string BirimMiktar { get; set; }

        [Column(TypeName = "money")]
        public string Miktar { get; set; }

        [Column(TypeName = "money")]
        public string SevkMiktar { get; set; }

        [Column(TypeName = "money")]
        public string OranIskonto3 { get; set; }

        [Column(TypeName = "money")]
        public string BirimFiyat { get; set; }

        [Column(TypeName = "money")]
        public string Fiyat { get; set; }

        [Column(TypeName = "money")]
        public string BirimTutar { get; set; }

        [Column(TypeName = "money")]
        public string Tutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string DovizTL { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi { get; set; }

        [Column(TypeName = "money")]
        public string DovizKuru { get; set; }

        [Column(TypeName = "money")]
        public string DovizBirimFiyat { get; set; }

        [Column(TypeName = "money")]
        public string DovizTutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Irsfat { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string KaynakEvrakTipi { get; set; }

        [Column(TypeName = "money")]
        public string KDVOran { get; set; }

        [Column(TypeName = "money")]
        public string KDVTutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string KDVDahilHaric { get; set; }

        [Column(TypeName = "money")]
        public string OTVOran { get; set; }


        [Column(TypeName = "money")]
        public string OTVTutar { get; set; }


        [Column(TypeName = "money")]
        public string OranIskonto { get; set; }

        [Column(TypeName = "money")]
        public string TutarIskonto { get; set; }

        [Column(TypeName = "money")]
        public string ToplamIskonto { get; set; }

        [Column(TypeName = "money")]
        public string MasrafTutar { get; set; }

        [Column(TypeName = "money")]
        public string OranIskonto2 { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Depo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string SeriNo { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IdSiparis { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod3 { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod5 { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        public DateTime KayitTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IDMalKodu { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }

    }
}