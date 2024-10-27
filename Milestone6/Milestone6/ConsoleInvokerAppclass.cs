using System;
using System.Diagnostics;

namespace ConsoleInvokerApp
{
    class ConsoleInvokerAppclass
    {
        static void Main(string[] args)
        {
            // Numbers to sum
            int number1 = 5;
            int number2 = 10;

            // Prepare the process start info
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "python", // Ensure Python is in your PATH
                Arguments = $"sum_script.py {number1} {number2}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            // Start the process
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();

                // Read the output
                string result = process.StandardOutput.ReadLine();
                process.WaitForExit();

                // Display the result
                Console.WriteLine($"The sum is: {result}");
            }
        }
    }
}
