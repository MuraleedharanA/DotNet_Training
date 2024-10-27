using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Outlook;
using static System.Net.Mime.MediaTypeNames;

namespace Milestone7
{
    
       class P3
        {
            static void Main(string[] args)
            {
                // Initialize Outlook application
                Application outlookApp = new Application();
                NameSpace outlookNamespace = outlookApp.GetNamespace("MAPI");
                MAPIFolder calendarFolder = outlookNamespace.GetDefaultFolder(OlDefaultFolderType.olFolderCalendar);
                Items calendarItems = calendarFolder.Items;

                // Set the time filter for upcoming events
                DateTime startDate = DateTime.Now;
                DateTime endDate = startDate.AddDays(30); // Get events for the next 30 days
                calendarItems.IncludeRecurrences = true;
                calendarItems.Sort("[Start]");

                // Filter items by start date
                string filter = $"[Start] >= '{startDate.ToString("g")}' AND [Start] <= '{endDate.ToString("g")}'";
                Items filteredItems = calendarItems.Restrict(filter);

                // Store upcoming events
                List<string> upcomingEvents = new List<string>();

                foreach (AppointmentItem item in filteredItems)
                {
                    if (item is AppointmentItem appointment)
                    {
                        upcomingEvents.Add($"{appointment.Subject}: {appointment.Start.ToString("yyyy-MM-dd hh:mm tt")}");
                    }
                }

                // Display upcoming events
                Console.WriteLine("Upcoming Events:");
                if (upcomingEvents.Count == 0)
                {
                    Console.WriteLine("No upcoming events found.");
                }
                else
                {
                    foreach (var evt in upcomingEvents)
                    {
                        Console.WriteLine($"- {evt}");
                    }
                }

                // Clean up
                System.Runtime.InteropServices.Marshal.ReleaseComObject(calendarItems);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(calendarFolder);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(outlookNamespace);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(outlookApp);

                Console.ReadLine();
            }
        }
    }


