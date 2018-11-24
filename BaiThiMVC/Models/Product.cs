using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiThiMVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public string UnitslnStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }


    }
}
