﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class TaahhutUstaBilgileri
    {
        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string UstaKodu { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string UstaAdi { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Tıp{ get; set; }

        [Column(TypeName = "text")]
        public string İscilikTipiT { get; set; }

        [Column(TypeName = "text")]
        public string İscilikTipiTAciklama { get; set; }

        [Column(TypeName = "text")]
        public string İscilikTipiAciklama { get; set; }

        [Column(TypeName = "text")]
        public string İscilikTipiMiktar { get; set; }

        [Column(TypeName = "text")]
        public string İscilikTipiFiyat { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal İscilik { get; set; }

        [Column(TypeName = "decimal(19,2)")]
        public decimal HakedisTutar { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string HakedisEvrakNo { get; set; }

        [Key]
        [Required]
        public DateTime BaslangicTarihi { get; set; }

        [Key]
        [Required]
        public DateTime BitisTarihi { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IDUstaKodu { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }


    }
}