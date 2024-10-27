using System;
using System.IO;
using Microsoft.SharePoint.Client;

namespace Milestone7
{
    

    
        class P2
        {
            static void Main(string[] args)
            {
                // Input parameters
                string siteUrl = "https://yourtenant.sharepoint.com/sites/yoursite";
                string libraryName = "Documents";
                string filePath = @"C:\file.docx";
                string username = "251210@ust.com";
                string password = "*****"; 

                // Connect to SharePoint
                using (var context = new ClientContext(siteUrl))
                {
                    // Secure password
                    context.Credentials = new SharePointOnlineCredentials(username, GetSecureString(password));

                    // Get the document library
                    List library = context.Web.Lists.GetByTitle(libraryName);

                    // Upload the file
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        var fileCreationInfo = new FileCreationInformation
                        {
                            ContentStream = fs,
                            Url = Path.GetFileName(filePath),
                            Overwrite = true
                        };

                        Microsoft.SharePoint.Client.File uploadFile = library.RootFolder.Files.Add(fileCreationInfo);
                        context.Load(uploadFile);
                        context.ExecuteQuery();

                        Console.WriteLine($"File uploaded successfully: {uploadFile.Name}");
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


