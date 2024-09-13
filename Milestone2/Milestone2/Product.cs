using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2
{
    internal class Product
    {
        public String productName {  get; set; }
        public Decimal price { get; set; }  
        public String category { get; set; }

        public Product(String name,decimal price, string category ) { 
            this.productName = name;
            this.price = price; 
            this.category = category;
        }

    }
}
