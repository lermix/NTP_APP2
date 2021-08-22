using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection;
using Syncfusion.Pdf.Security;

// Syncfusion.Pdf.WinForms nuGet package needed
namespace NTP_Ivo_Ojvan.Tools
{
    /// <summary>
    /// Creates pdf document with table created from list, 
    /// Location example @"C:\Users\Alen\Desktop\output.pdf"
    /// </summary>
    public static class PDFManager
    {

        public static void createPDFfromList<T>(List<T> items, string title, string location)
        {
            //Create a new PDF document
            PdfDocument doc = new PdfDocument();
            //Add a page
            PdfPage page = doc.Pages.Add();
            //Create PDF graphics for the page.
            PdfGraphics graphics = page.Graphics;
            //Set the standard font.
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
            //Draw the text.
            PdfTextElement textElement = new PdfTextElement(title, font);
            textElement.Draw(graphics, new PointF(200, 0));
        
            //Create a PdfGrid
            PdfGrid pdfGrid = new PdfGrid();
            //Create table from list           
            var myType = typeof(T);
            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in myType.GetProperties())
            {
                dataTable.Columns.Add(new DataColumn(info.Name, info.PropertyType));                
            }
            foreach (var item in items)
            {
                DataRow dr = dataTable.NewRow();
                foreach (PropertyInfo info in myType.GetProperties())
                {
                    dr[info.Name] = info.GetValue(item);                                        
                }
                dataTable.Rows.Add(dr);
            }
            //Assign data source
            pdfGrid.DataSource = dataTable;
            //Draw grid to the page of PDF document
            pdfGrid.Draw(page, new PointF(0, 50));

            //SIGNATURE
            //Creates a certificate instance from PFX file with private key
            //xca program used to create pfx file
            PdfCertificate pdfCert = new PdfCertificate(@"cer1.p12", "258456");

            //Creates a digital signature
            PdfSignature signature = new PdfSignature(doc, page, pdfCert, "Signature");

            //Sets signature information
            signature.ContactInfo = "IvoOjvan@ntp.com";
            signature.LocationInfo = "Zagreb, Croatia";
            signature.Reason = "I am author of this document.";

            //Save the document
            doc.Save(location);
            //Close the document
            doc.Close(true);            
        }       

    

  
    }
}
