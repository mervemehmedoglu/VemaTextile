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
        [Column(TypeName = "nvarchar")]
        [StringLength(57)]
        public string DocumentNumber { set; get; }
        [Column(TypeName = "nvarchar")]
        [StringLength(4)]
        public string  Serial { set; get; }
        [Column(TypeName = "numeric")]
        [StringLength(30)]
        public int IDNumber { set; get; }

        public DateTime Date { set; get; }
        public string OptionDay { set; get; }
        public DateTime ExpiryDate { set; get; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string OperationType { set; get; }
        public string SourceDocumentType { set; get; }
        public string AccountCode { set; get; }
        public string AccountName { set; get; }
        public int CurrencyTL { set; get; }
        public int Total { set; get; }
        public int CurrencyType { set; get; }
        public int ExchangeRate { set; get; }
        public int CurrencyAmount { set; get; }
        public int KDVTotal{ set; get; }
        public int OTVTotal{ set; get; }
        public int DiscountAmount{ set; get; }
        public string AdvanceTerm{ set; get; }
        public string CounterAccountCode{ set; get; }
        public string CounterAccountName{ set; get; }
        public string ResidualEffect{ set; get; }
        public string Code1{ set; get; }
        public string Code2{ set; get; }
        public string Code3{ set; get; }
        public string Code4{ set; get; }
        public string Code5{ set; get; }
        public string Comment{ set; get; }
        public string RegisteredPerson{ set; get; }
        public DateTime RegisteredDate{ set; get; }
        public string UpdatePerson{ set; get; }
        public DateTime UpdateDate{ set; get; }
        public string IDaccountCode{ set; get; }
        public int RowID{ set; get; }

       


    }
}