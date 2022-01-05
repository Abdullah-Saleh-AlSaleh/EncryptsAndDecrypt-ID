using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.net_Mvc_Encrypts_And_Decrypt_ID.Models
{
    public class Store
    {
        public string StoreID { get; set; }
        [Display(Name = "اسم المنتج")]
        public string ProducetName { get; set; }
        [Display(Name = "تفاصيل المنتج")]
        public string ProducetDetails { get; set; }
        [Display(Name = "سعر")]
        public string Price { get; set; }
        public string Decrypts { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;   
    }
}