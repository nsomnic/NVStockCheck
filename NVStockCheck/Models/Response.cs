using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NVStockCheck.Models
{
    public class Response
    {
        public Products products { get; set; }
    }
    
    public class Products
    {
        public List<Product> product { get; set; }
    }  

    public class Product
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string thumbnailImage { get; set; }
        public Pricing pricing { get; set; }
        public InventoryStatus inventoryStatus { get; set; }
    }

    public class Pricing
    {
        public string formattedListPrice { get; set; }
        public listPrice listPrice { get; set; }
    }

    public class listPrice
    { 
        public decimal value { get; set; }
    }


    public class InventoryStatus 
    {
        public string status { get; set; }
    }

}
