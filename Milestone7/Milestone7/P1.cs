namespace Milestone7
{
    using System;
    using System.Collections.Generic;
    using Microsoft.SharePoint.Client;

    namespace SharePointDocumentLibrary
    {
        class P1
        {
            static void Main(string[] args)
            {
                
                string siteUrl = "https://yourtenant.sharepoint.com/sites/yoursite";
                string libraryName = "Documents";
                string username = "251210@ust.com";
                string password = "****";
                     

                // Connect to SharePoint
                using (var context = new ClientContext(siteUrl))
                {
                    // Secure password
                    context.Credentials = new SharePointOnlineCredentials(username, GetSecureString(password));

                    // Get the document library
                    List library = context.Web.Lists.GetByTitle(libraryName);

                    // Query the items in the library
                    CamlQuery query = CamlQuery.CreateAllItemsQuery();
                    ListItemCollection items = library.GetItems(query);

                    // Load the items
                    context.Load(items);
                    context.ExecuteQuery();

                    // Output the names of all documents
                    Console.WriteLine("Document List:");
                    foreach (ListItem item in items)
                    {
                        if (item.FileSystemObjectType == FileSystemObjectType.File)
                        {
                            Console.WriteLine($"- {item["FileLeafRef"]}");
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

}