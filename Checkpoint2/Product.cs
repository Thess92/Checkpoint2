using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2
{
    class Product : ProductCategory
    {
        public Product(string category, string productName, double price) : base(category)
        {
            ProductName = productName;
            Price = price;
        }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
}
