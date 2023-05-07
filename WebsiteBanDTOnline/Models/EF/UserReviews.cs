using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace WebsiteBanDTOnline.Models.EF
{
    [Table("tb_UserReview")]
    public class UserReviews : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public bool Is1Star { get; set; }
        public bool Is2Star { get; set; }
        public bool Is3Star { get; set; }
        public bool Is4Star { get; set; }
        public bool Is5Star { get; set; }
        [StringLength(750)]
        public string Comment { get; set; }
        public virtual Product Product { get; set; }
    }
}