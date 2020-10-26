using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VemaTextile.Models.Class
{
    public class CurrentAccountCards
    {
        [Key]
        [Required]
        public int AccountID { get; set; }
        [Required]
        public string AccountName { get; set; }
        public string AccountName2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(15)] 
        public string CardType { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string BillAdress { get; set; }     
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string BillAdres2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string BillAdres3 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(15)] 
        public string Telephone { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(15)] 
        public string Telephone2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(15)] 
        public string Fax { get; set; }  
        [Column(TypeName = "nvarchar")]
        [StringLength(15)] 
        public string Fax2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)] 
        public string authorized { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(70)] 
        public string WebAdress { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string TaxOffice { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string TaxNo { get; set; }
        public int DiscountRate { get; set; }
        public int OptionDay { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string PaymentDay { get; set; }    
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string CurrencyType { get; set; }
        [Column(TypeName = "money")]
        public decimal CreditLimit { get; set; }
        [Column(TypeName = "money")]
        public decimal CurrencyCreditLimit { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string RegionCode { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string SpecialCode { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string GroupCode { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string TypeCode { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Code1 { get; set; }  
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Code2 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Code3 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Code4 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Code5 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Code6 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Code7 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Code8 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Code9 { get; set; }
        [Column(TypeName = "money")]
        public decimal Code10 { get; set; }
        [Column(TypeName = "money")]
        public decimal Code11 { get; set; }
        [Column(TypeName = "money")]
        public decimal Code12 { get; set; }
        [Column(TypeName = "money")]
        public decimal Code13 { get; set; }
        [Column(TypeName = "money")]
        public decimal Code14 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string Comment1 { get; set; }
        [Column(TypeName = "text")]
        public string Comment2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string IdentityCardSerialNumber { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string IdentificationNumber { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string MotherName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string FatherName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string BirthDate { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string BirthPlace { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)] 
        public string SuretyName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string SuretyTelephone { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string SuretyIdentityCardSerialNumber { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string SuretyIdentificationNumber { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string SuretyMotherName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string SuretyFatherName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string SuretyBirthDate { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string SuretyBirthPlace { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string SuretyAdress1 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string SuretyAdress2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)] 
        public string ReceiverPerson { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string DeliveryAddress { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string DeliveryAddress2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string DeliveryAddress3 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string RegisteredPerson { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime RegistrationTime { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string RegistrationSource { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string UpdatePerson { get; set; } 
        public DateTime UpdateDate { get; set; } 
        public DateTime UpdateTime { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string UpdateSource { get; set; }    
        [Column(TypeName = "decimal(18,0)")]
        public decimal RowID { get; set; }



        
            




    }
}