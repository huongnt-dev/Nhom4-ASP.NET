using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Nhom4
{
    public class ProductCategory
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }    
        public string CategoryName { get; set; }    
        public bool? ProductStatus { get; set; }
        public string ProductImg { get; set; }
    }
}