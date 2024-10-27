using System;
using Microsoft.Office.Interop.Outlook;

namespace Milestone7
{
    class P4
    {
        static void Main(string[] args)
        {
            // Input parameters
            string recipient = "athira.muraleedharan@ust.com";
            string subject = "Monthly Report";
            string body = "Please find the attached report.";
            string attachmentPath = @"C:\report.pdf";

            // Initialize Outlook application
            Application outlookApp = new Application();
            try
            {
                // Create a new email item
                MailItem email = (MailItem)outlookApp.CreateItem(OlItemType.olMailItem);
                email.To = recipient;
                email.Subject = subject;
                email.Body = body;

                // Add attachment if the file exists
                if (System.IO.File.Exists(attachmentPath))
                {
                    email.Attachments.Add(attachmentPath);
                }
                else
                {
                    Console.WriteLine($"Attachment not found: {attachmentPath}");
                    return;
                }

                // Send the email
                email.Send();
                Console.WriteLine($"Email sent successfully to {recipient}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email: {ex.Message}");
            }
            finally
            {
                // Clean up COM objects
                System.Runtime.InteropServices.Marshal.ReleaseComObject(outlookApp);
            }

            Console.ReadLine();
        }
    }
}
