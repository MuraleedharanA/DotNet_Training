using System;
using Microsoft.SharePoint.Client;

namespace SharePointLMilestone7istRetriever
{
    class P5
    {
        static void Main(string[] args)
        {
            // Input parameters
            string siteUrl = "https://yourtenant.sharepoint.com/sites/yoursite";
            string listName = "Tasks";
            string username = "athira@ust.onmicrosoft.com";
            string password = "*****"; 
            // Connect to SharePoint
            using (var context = new ClientContext(siteUrl))
            {
                // Secure password
                context.Credentials = new SharePointOnlineCredentials(username, GetSecureString(password));

                // Get the list
                List tasksList = context.Web.Lists.GetByTitle(listName);

                // Query the items in the list
                CamlQuery query = CamlQuery.CreateAllItemsQuery();
                ListItemCollection items = tasksList.GetItems(query);

                // Load the items
                context.Load(items);
                context.ExecuteQuery();

                // Output the items
                Console.WriteLine("Tasks List:");
                foreach (ListItem item in items)
                {
                    if (item.FieldValues.ContainsKey("Title"))
                    {
                        Console.WriteLine($"- {item["Title"]}: {item["Body"]}");
                    }
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
