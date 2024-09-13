namespace Milestone2_Polymorphism
{
    using System;

    public class Order
    {
        public decimal TotalAmount { get; set; }

        // Virtual method to calculate the total amount
        public virtual decimal CalculateTotalAmount()
        {
            return TotalAmount;
        }
        // Method to add a product with price and quantity
        public void AddProduct(decimal price, int quantity)
        {
            TotalAmount += price * quantity;
        }

        // Overloaded method to add a product with price, quantity, and discount
        public void AddProduct(decimal price, int quantity, decimal discount)
        {
            TotalAmount += (price * quantity) - discount;
        }
    }

    public class DiscountedOrder : Order
    {
        public decimal Discount { get; set; }

        // Override method to calculate the total amount with discount
        public override decimal CalculateTotalAmount()
        {
            return TotalAmount - Discount;
        }
    }
    

    class Program
    {
        static void Main()
        {
            // Create an Order object
            Order basicOrder = new Order();
            basicOrder.AddProduct(100m, 2);
            Console.WriteLine($"Basic Order Total Amount: {basicOrder.CalculateTotalAmount():C}");

            // Create a DiscountedOrder object
            DiscountedOrder discountedOrder = new DiscountedOrder();
            discountedOrder.AddProduct(100m, 2);
            discountedOrder.Discount = 20m;
            Console.WriteLine($"Discounted Order Total Amount: {discountedOrder.CalculateTotalAmount():C}");

            // Demonstrate method overloading
            Order orderWithDiscount = new Order();
            orderWithDiscount.AddProduct(50m, 3, 15m); // Adds a product with a discount
            Console.WriteLine($"Order with Discount Total Amount: {orderWithDiscount.CalculateTotalAmount():C}");
        }
    }

}