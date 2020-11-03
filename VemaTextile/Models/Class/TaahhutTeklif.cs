using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class TaahhutTeklif
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
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TesisatAdresi1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TesisatAdresi2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TesisatAdresi3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Telefon1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Telefon2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Telefon3 { get; set; }

        [Column(TypeName = "money")]
        public decimal AnlasmaTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal PesinatTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal VadeFarkiOrani { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar1 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar2 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar3 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar4 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar5 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar6 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar7 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar8 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar9 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar10 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar11 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar12 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar13 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar14 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar15 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar16 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar17 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar18 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar19 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTeklifTutar20 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiMarka1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiMarka2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiMarka3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiMarka4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiTipi1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiTipi2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiTipi3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiTipi4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiModeli1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiModeli2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiModeli3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiModeli4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiKapasite1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiKapasite2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiKapasite3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiKapasite4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiGaranti1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiGaranti2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiGaranti3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiGaranti4 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiEuroFiyat1 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiEuroFiyat2 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiEuroFiyat3 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTLFiyat1 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTLFiyat2 { get; set; }

        [Column(TypeName = "money")]
        public decimal KombiTLFiyat3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörMarka1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörMarka2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörMarka3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörMarka4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörTipi1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörTipi2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörTipi3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörTipi4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörModeli1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörModeli2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörModeli3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörModeli4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörGaranti1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörGaranti2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörGaranti3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörGaranti4 { get; set; }

        [Column(TypeName = "money")]
        public decimal RadyatörEuroFiyat1 { get; set; }

        [Column(TypeName = "money")]
        public decimal RadyatörEuroFiyat2 { get; set; }

        [Column(TypeName = "money")]
        public decimal RadyatörEuroFiyat3 { get; set; }

        [Column(TypeName = "money")]
        public decimal RadyatörEuroFiyat4 { get; set; }

        [Column(TypeName = "money")]
        public decimal RadyatörTLFiyat1 { get; set; }

        [Column(TypeName = "money")]
        public decimal RadyatörTLFiyat2 { get; set; }

        [Column(TypeName = "money")]
        public decimal RadyatörTLFiyat3 { get; set; }

        [Column(TypeName = "money")]
        public decimal RadyatörTLFiyat4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi5 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi6 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi7 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi8 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi9 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi10 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu5 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu6 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu7 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu8 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu9 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu10 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörOlcu1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörOlcu2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörOlcu3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörOlcu4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörOlcu5 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörOlcu6 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörOlcu7 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörOlcu8 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörOlcu9 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatörOlcu10 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Kaydeden { get; set; }

        public DateTime KayitTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }


    }
}