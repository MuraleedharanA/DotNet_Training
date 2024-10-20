using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PdfReportGenerator
{
    class Program
    {
        static void Main1(string[] args)
        {
            // Sample input
            string title = "Monthly Sales Report";
            string text = "Total Sales: $10,000";
            string imagePath = @"C:\images\sales_chart.png"; 

            // Output PDF file path
            string pdfPath = @"SalesReport.pdf";

            // Create the PDF document
            using (FileStream fs = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, fs);
                document.Open();

                // Add title
                Font titleFont = FontFactory.GetFont("Arial", 20, Font.BOLD);
                Paragraph titleParagraph = new Paragraph(title, titleFont);
                titleParagraph.Alignment = Element.ALIGN_CENTER;
                document.Add(titleParagraph);

                // Add some spacing
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph(" "));

                // Add text
                Font textFont = FontFactory.GetFont("Arial", 12, Font.NORMAL);
                Paragraph textParagraph = new Paragraph(text, textFont);
                textParagraph.Alignment = Element.ALIGN_LEFT;
                document.Add(textParagraph);

                // Add image
                if (File.Exists(imagePath))
                {
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);
                    image.ScaleToFit(500, 500); 
                    image.Alignment = Element.ALIGN_CENTER;
                    document.Add(image);
                }
                else
                {
                    Console.WriteLine("Image not found at the specified path.");
                }

                // Close the document
                document.Close();
            }

            Console.WriteLine("PDF generated successfully: " + pdfPath);
        }
    }
}
