using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;
using Font = iTextSharp.text.Font;

namespace PointOfSale.Report
{
    internal class ExportPdfReportGenerator:IReportGenerator
    {
        public void exportPdf(Chart chart1, Chart chartEmpSales, DataGridView dataGridViewRevenue)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "FullReport.pdf");

            Document document = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

           
            Paragraph title = new Paragraph("Sales Report", new Font(Font.FontFamily.HELVETICA, 18f, Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20f;
            document.Add(title);

            
            using (MemoryStream chartStream = new MemoryStream())
            {
                chart1.SaveImage(chartStream, ChartImageFormat.Png);
                iTextSharp.text.Image chartImg = iTextSharp.text.Image.GetInstance(chartStream.ToArray());
                chartImg.Alignment = Element.ALIGN_CENTER;
                chartImg.ScaleToFit(700f, 300f);
                chartImg.SpacingAfter = 20f;
                document.Add(new Paragraph("Monthly Sales Chart", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                document.Add(chartImg);
            }


           
            document.Add(new Paragraph("Revenue Breakdown Table", FontFactory.GetFont("Arial", 12, Font.BOLD)));
            PdfPTable pdfTable = new PdfPTable(dataGridViewRevenue.ColumnCount);
            pdfTable.WidthPercentage = 100;
            pdfTable.SpacingBefore = 10f;
            pdfTable.SpacingAfter = 20f;

           
            foreach (DataGridViewColumn col in dataGridViewRevenue.Columns)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(col.HeaderText, FontFactory.GetFont("Arial", 10, Font.BOLD)));
                headerCell.BackgroundColor = new BaseColor(220, 220, 220);
                pdfTable.AddCell(headerCell);
            }

     
            foreach (DataGridViewRow row in dataGridViewRevenue.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellText = cell.Value?.ToString() ?? "";
                    pdfTable.AddCell(new Phrase(cellText, FontFactory.GetFont("Arial", 10)));
                }
            }

            document.Add(pdfTable);

            using (MemoryStream pieStream = new MemoryStream())
            {
                chartEmpSales.SaveImage(pieStream, ChartImageFormat.Png);
                iTextSharp.text.Image pieImg = iTextSharp.text.Image.GetInstance(pieStream.ToArray());
                pieImg.Alignment = Element.ALIGN_CENTER;
                pieImg.ScaleToFit(700f, 300f);
                pieImg.SpacingAfter = 20f;
                document.Add(new Paragraph("Employee Sales Distribution", FontFactory.GetFont("Arial", 12, Font.BOLD)));
                document.Add(pieImg);
            }

            document.Close();

            
            writer.Close();

            MessageBox.Show("Full report PDF saved to desktop!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
