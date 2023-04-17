using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace WebsiteBanDTOnline.Models
{
    public abstract class CommonAbstract
    {
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CreatedTime { get; set;}
        public string ModifiedDate { get; set; }
    }
}