using System;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PdfReportGenerator
{
    class PDF2
    {
        static void Main(string[] args)
        {
            string csvFilePath = @"C:\path\to\your\data.csv"; // Update the path to your CSV file
            string pdfPath = @"SummaryReport.pdf";

            // Read CSV data
            var records = ReadCsv(csvFilePath);

            // Generate PDF report
            CreatePdfReport(records, pdfPath);

            Console.WriteLine("PDF generated successfully: " + pdfPath);
        }

        static List<Record> ReadCsv(string path)
        {
            var records = new List<Record>();
            var lines = File.ReadAllLines(path);

            foreach (var line in lines[1..]) // Skip the header line
            {
                var columns = line.Split(',');
                if (columns.Length == 2)
                {
                    records.Add(new Record { Name = columns[0], Amount = decimal.Parse(columns[1]) });
                }
            }

            return records;
        }

        static void CreatePdfReport(List<Record> records, string pdfPath)
        {
            using (FileStream fs = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, fs);
                document.Open();

                // Add title
                document.Add(new Paragraph("Summary Report", FontFactory.GetFont("Arial", 20, Font.BOLD)) { Alignment = Element.ALIGN_CENTER });
                document.Add(new Paragraph(" "));

                // Create table
                PdfPTable table = new PdfPTable(2);
                table.AddCell("Name");
                table.AddCell("Amount");

                // Populate table with data
                foreach (var record in records)
                {
                    table.AddCell(record.Name);
                    table.AddCell(record.Amount.ToString("C")); // Format as currency
                }

                document.Add(table);
                document.Close();
            }
        }

        class Record
        {
            public string Name { get; set; }
            public decimal Amount { get; set; }
        }
    }
}


