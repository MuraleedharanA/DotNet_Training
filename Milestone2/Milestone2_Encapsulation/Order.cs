﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2
{
    internal class Order
    {
        public List<Product> products {  get; set; }
        public decimal orderTotal {  get; set; }

        public void orderTotalCal(List<Product> productList)
        {
            this.orderTotal =  productList.Sum(P => P.price);
            
        }
        public void orderTotalCal(List<Product> productList, decimal discount)
        {
            decimal totalAmount = productList.Sum(P => P.price);
            decimal discountAmount = totalAmount * (discount / 100);
            this.orderTotal = totalAmount - discountAmount;

        }
    }
}