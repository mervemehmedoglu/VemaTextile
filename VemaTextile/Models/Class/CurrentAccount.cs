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
        public string DocumentNumber { set; get; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(4)]
        public string  Serial { set; get; }
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal IDNumber { set; get; }
        public DateTime Date { set; get; }
        [Column(TypeName = "money")]
        public decimal OptionDay { set; get; }
        public DateTime ExpiryDate { set; get; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(6)]
        public string OperationType { set; get; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(80)]
        public string SourceDocumentType { set; get; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string AccountCode { set; get; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string AccountName { set; get; }
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string CurrencyTL { set; get; }
        [Column(TypeName = "money")]
        public decimal Total { set; get; }
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public int CurrencyType { set; get; }
        [Column(TypeName = "money")]
        public decimal ExchangeRate { set; get; }
        [Column(TypeName = "money")]
        public decimal CurrencyAmount { set; get; }
        [Column(TypeName = "money")]
        public decimal KDVTotal{ set; get; }
        [Column(TypeName = "money")]
        public decimal OTVTotal{ set; get; }
        [Column(TypeName = "money")]
        public decimal DiscountAmount{ set; get; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string AdvanceTerm{ set; get; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CounterAccountCode{ set; get; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string CounterAccountName{ set; get; }
        [Column(TypeName = "nvarchar")]
        [StringLength(3)]
        public string ResidualEffect{ set; get; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Code1{ set; get; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Code2{ set; get; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Code3{ set; get; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Code4{ set; get; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Code5{ set; get; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Comment{ set; get; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RegisteredPerson{ set; get; }
        public DateTime RegisteredDate{ set; get; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string UpdatePerson{ set; get; }
        public DateTime UpdateDate{ set; get; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IDaccountCode{ set; get; }
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal RowID{ set; get; }

       


    }
}