using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class CurrentAccountCards
    {
        [Key]
        public int AccountID { get; set; }
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
        
        public string CreditLimit { get; set; }
        

        public int CurrencyCreditLimit { get; set; }

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

        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string Code1 { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string Code2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string Code3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string Code4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string Code5 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string Code6 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string Code7 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string Code8 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string Code9 { get; set; }
        public int Code10 { get; set; }
        public int Code11 { get; set; }
        public int Code12 { get; set; }
        public int Code13 { get; set; }
        public int Code14 { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string Comment1 { get; set; }
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
        [StringLength(30)]
        public string RegisteredPerson { get; set; }
        
        public string RegistrationDate { get; set; }
        
        public string RegistrationTime { get; set; }
        
        public string RegistrationSource { get; set; }
        

       
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string UpdatePerson { get; set; }
        
        public string UpdateDate { get; set; }
        
        public string UpdateTime { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string UpdateSource { get; set; }
        
        public string RowID { get; set; }



        
            




    }
}