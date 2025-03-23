using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITECManagementSystem.DL
{
    internal class EventReportDL
    {
        public void GenerateEventReport()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=MidProjectDb;uid=root;pwd=Vat02842@Vat02842@;"))
                {
                    conn.Open();
                    string query = "SELECT e.event_name , e.event_date ,c.committee_name AS Commitees , v.venue_name FROM itec_events e JOIN committees c ON e.committee_id = c.committee_id JOIN venues v ON e.venue_id = v.venue_id "; 
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Document doc = new Document(PageSize.A4);
                    string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Report.pdf");
                    PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));

                    doc.Open();
                    iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                    Paragraph title = new Paragraph("Events Report\n\n", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);
                    PdfPTable table = new PdfPTable(dt.Columns.Count);
                    table.WidthPercentage = 100;
                    foreach (DataColumn column in dt.Columns)
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                        headerCell.BackgroundColor = new BaseColor(200, 200, 200);
                        headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(headerCell);
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (object cellData in row.ItemArray)
                        {
                            table.AddCell(new Phrase(cellData.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                        }
                    }

                    doc.Add(table);
                    doc.Close();
                    conn.Close();
                    MessageBox.Show("PDF Report Generated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
