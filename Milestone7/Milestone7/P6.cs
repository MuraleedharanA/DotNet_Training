using System;
using Microsoft.SharePoint.Client;

namespace Milestone7
{
    class P6
    {
        static void Main(string[] args)
        {
            // Input parameters
            string siteUrl = "https://ust.sharepoint.com/sites/yoursite";
            string listName = "Tasks";
            int itemId = 1; 
            string updatedTitle = "Complete the monthly report";
            string username = "athira@ust.onmicrosoft.com";
            string password = "******"; 
            // Connect to SharePoint
            using (var context = new ClientContext(siteUrl))
            {
                // Secure password
                context.Credentials = new SharePointOnlineCredentials(username, GetSecureString(password));

                try
                {
                    // Get the list
                    List tasksList = context.Web.Lists.GetByTitle(listName);

                    // Get the item by ID
                    ListItem item = tasksList.GetItemById(itemId);
                    context.Load(item);
                    context.ExecuteQuery();

                    // Update the title
                    item["Title"] = updatedTitle;
                    item.Update();
                    context.ExecuteQuery();

                    Console.WriteLine($"Item updated successfully: Task ID {itemId}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to update item: {ex.Message}");
                }
            }

            Console.ReadLine();
        }

        private static System.Security.SecureString GetSecureString(string password)
        {
            var secureString = new System.Security.SecureString();
            foreach (char c in password)
            {
                secureString.AppendChar(c);
            }
            return secureString;
        }
    }
}
