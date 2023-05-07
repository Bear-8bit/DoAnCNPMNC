using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.WebPages;

namespace WebsiteBanDTOnline.Models.EF
{
    [Table("tb_Products")]
    public class Product : CommonAbstract
    {
        public Product() 
        {
            this.ProductImages = new HashSet<ProductImage>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductCate_ID { get; set; }
        [StringLength(250)]
        public string Alias { get; set; }
        [Required]
        [StringLength(250)]
        public string ProductName { get; set; }
        [StringLength(50)]
        public string ProductCode { get; set; }
        public string Description { get; set; }
        [StringLength(10000)]
        public string Detail { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceSale { get; set;}
        public decimal OriginalPrice { get; set; }
        public bool IsHome { get; set; }
        public bool IsSale { get; set; }
        public bool IsFeature { get; set; } 
        public bool IsHot { get; set; }
        public int Quantity { get; set; }
        public int ViewCount { get; set; }
        public bool IsActive { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeywords { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<UserReviews> UserReviews { get; set; }
    }
}