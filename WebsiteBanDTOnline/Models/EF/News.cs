using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebsiteBanDTOnline.Models.EF
{
    [Table("tb_News")]
    public class News : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Menu_ID { get; set; }
        [Required(ErrorMessage = "Tên tiêu đề không được để trống")]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set;}
        public string SeoKeywords { get; set; }
        public bool IsActive { get; set; }

        public virtual Categories Categories { get; set; }
    }
}