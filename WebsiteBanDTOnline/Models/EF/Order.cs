using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebsiteBanDTOnline.Models.EF
{
    [Table("tb_Orders")]
    public class Order : CommonAbstract
    {
        public Order() 
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }  
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Code { get; set; }
        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }
        public int TypePayment { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}