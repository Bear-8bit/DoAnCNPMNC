using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteBanDTOnline.Models.EF
{
    [Table("tb_Survey")]
    public class Survey : CommonAbstract
    {
        [Key, ForeignKey("User")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public int Age { get; set; }
        public string Email { get; set; }
        public bool IsRecommended { get; set; }
        public bool IsNotRecommended { get; set; }
        public string Comment { get; set; }
        public bool Is1Star { get; set; }
        public bool Is2Star { get; set; }
        public bool Is3Star { get; set; }
        public bool Is4Star { get; set; }
        public bool Is5Star { get; set; }
        public bool IsActive { get; set; }
        public virtual User User { get; set; }
    }
}