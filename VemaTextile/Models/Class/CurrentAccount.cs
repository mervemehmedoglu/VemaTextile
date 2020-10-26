using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class CurrentAccount
    {
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(57)]
        public string EvrakNo{ set; get; }
        
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(4)]
        public string  Seri { set; get; }
       
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal IdNo { set; get; }
       
        public DateTime Tarih { set; get; }
        
        [Column(TypeName = "money")]
        public decimal OpsiyonGunu{ set; get; }
        
        public DateTime VadeTarihi { set; get; }
       
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(6)]
        public string IslemTuru { set; get; }
       
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(80)]
        public string KaynakEvrakTipi { set; get; }
       
        [Required]
        [Column(TypeName = "nvarchar")]
        public string HesapKodu { set; get; }
       
        [Required]
        [Column(TypeName = "nvarchar")]
        public string HesapAdi { set; get; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string DovizTL { set; get; }
       
        [Column(TypeName = "money")]
        public decimal Tutar { set; get; }
       
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public int DovizCinsi { set; get; }
        
        [Column(TypeName = "money")]
        public decimal DovizKuru { set; get; }
        
        [Column(TypeName = "money")]
        public decimal DovizTutar { set; get; }
        
        [Column(TypeName = "money")]
        public decimal KDVTutar{ set; get; }
        
        [Column(TypeName = "money")]
        public decimal OTVTutar{ set; get; }
       
        [Column(TypeName = "money")]
        public decimal IskontoTutar{ set; get; }
       
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string PesinVadeli{ set; get; }
       
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KarsiHesapKOdu{ set; get; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string KarsiHesapAdi{ set; get; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(3)]
        public string BakiyeEtkisi{ set; get; }
        
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Kod1{ set; get; }
       
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Kod2{ set; get; }
        
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Kod3{ set; get; }
        
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Kod4{ set; get; }
       
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Kod5{ set; get; }
       
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Aciklama{ set; get; }
       
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden{ set; get; }
        
        public DateTime KayitTarihi{ set; get; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Degistiren{ set; get; }
        public DateTime DegisiklikTarihi{ set; get; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IDHesapKodu{ set; get; }
        
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID{ set; get; }

       


    }
}