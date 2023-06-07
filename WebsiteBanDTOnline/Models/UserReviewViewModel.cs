using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteBanDTOnline.Models
{
    public class UserReviewViewModel
    {   
        public int Product_Id { get; set; }
        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        public string Email { get; set; }
        public string Comment { get; set; }
        public bool Is1Star { get; set; }
        public bool Is2Star { get; set; }
        public bool Is3Star { get; set; }
        public bool Is4Star { get; set; }
        public bool Is5Star { get; set; }
    }
}