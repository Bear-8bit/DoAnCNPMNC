﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebsiteBanDTOnline.Models.EF
{
    [Table("tb_Subcribed")]
    public class Subcribe
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}