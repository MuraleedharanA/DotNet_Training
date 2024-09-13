namespace Milestone2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Pen", 10, "Stationary");
            Product product2 = new Product("Pencil", 10, "Stationary");
            Product product3 = new Product("Paper", 2, "Stationary");

            User user = new User("Athira","12345","abc@gmail.com");

            Order order = new Order();
            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);

            order.orderTotalCal(products);

            Console.WriteLine("Order Total :" + order.orderTotal);
        }
    }
}