using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class TaahhutAciklama
    {
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string Seri { get; set; }


    }
}