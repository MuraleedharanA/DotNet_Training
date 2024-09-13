namespace Milestone2_Interface
{
    public interface IOrderProcessor
    {
        void ProcessOrder(string orderId);
        void CancelOrder(string orderId);
    }
    public class PaymentProcessor : IOrderProcessor
    {
        public void ProcessOrder(string orderId)
        {
            // Logic to process payment
            System.Console.WriteLine($"Processing payment for order ID: {orderId}");
        }

        public void CancelOrder(string orderId)
        {
            // Logic to cancel payment
            System.Console.WriteLine($"Cancelling payment for order ID: {orderId}");
        }
    }
    public class ShippingProcessor : IOrderProcessor
    {
        public void ProcessOrder(string orderId)
        {
            // Logic to ship order
            System.Console.WriteLine($"Shipping order ID: {orderId}");
        }

        public void CancelOrder(string orderId)
        {
            // Logic to cancel shipment
            System.Console.WriteLine($"Cancelling shipment for order ID: {orderId}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create instances of PaymentProcessor and ShippingProcessor
            IOrderProcessor paymentProcessor = new PaymentProcessor();
            IOrderProcessor shippingProcessor = new ShippingProcessor();

            // Example order ID
            string orderId = "12345";

            // Process order
            paymentProcessor.ProcessOrder(orderId);
            shippingProcessor.ProcessOrder(orderId);

            // Cancel order
            paymentProcessor.CancelOrder(orderId);
            shippingProcessor.CancelOrder(orderId);
        }
    }

}