using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2
{
    class Product : ProductPrice
    {
        public Product(string category, string productName, double price) : base(price)
        {
            Category = category;
            ProductName = productName;
        }

        public string Category { get; set; }
        public string ProductName { get; set; }
    }
}
