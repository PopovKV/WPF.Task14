using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Task14
{
    public enum ProductCategories
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImgPath { get; set; }
        public ProductCategories ProductCategory { get; set; }
    }
}
