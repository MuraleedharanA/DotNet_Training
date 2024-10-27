using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LoggingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up dependency injection
            var serviceProvider = new ServiceCollection()
                .AddLogging(builder =>
                {
                    builder.AddConsole();
                    builder.AddFile("logs/app.log"); // Specify log file path
                })
                .BuildServiceProvider();

            // Create a logger
            var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

            // Log messages
            logger.LogInformation("Application started");
            PerformOperation(logger);
            logger.LogInformation("Application ended");

            Console.ReadLine();
        }

        static void PerformOperation(ILogger logger)
        {
            logger.LogInformation("Performing operation...");
            // Simulate some work
            System.Threading.Thread.Sleep(1000); // Sleep for demonstration
        }
    }
}
