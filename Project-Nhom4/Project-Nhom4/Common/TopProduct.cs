using Model.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_Nhom4.Common
{
    public class TopProduct
    {
        public List<Product> ProductNew { get; set; }
        public List<Product> Best_sellingProduct { get; set; }
    }
}