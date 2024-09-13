class Program
{
    static void Main()
    {
        // Create a Product object
        Product product = new Product("Laptop", 999.99m, 50);
        product.DisplayProductInfo();

        // Update the product price
        product.UpdatePrice(899.99m);
        System.Console.WriteLine("Updated Product Info:");
        product.DisplayProductInfo();

        // Create a User object
        User user = new User("johndoe", "john@example.com", 25);
        user.DisplayUserInfo();

        // Update the user email
        user.UpdateEmail("john.doe@example.com");
        System.Console.WriteLine("Updated User Info:");
        user.DisplayUserInfo();
    }
}
