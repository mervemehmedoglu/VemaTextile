using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string UserAppellation { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string UserPassword { get; set; }
        public DateTime UserAddedDate { get; set; }
        public DateTime UserUpdatedDate { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string UserAddingStaff { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string UserUpdatingStaff { get; set; }

            
    }
}