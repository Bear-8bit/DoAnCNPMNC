using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebsiteBanDTOnline.Models.EF
{
    [Table("tb_ProductCategorys")]
    public class ProductCategory : CommonAbstract
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>(); ;
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public string Image { get; set; }
        [StringLength(150)]
        public string Alias { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}