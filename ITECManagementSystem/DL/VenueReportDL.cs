using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ITECManagementSystem.DL
{
    internal class VenueReportDL
    {
        public void GenerateVenueReport()
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveDialog.FileName = "VenueReport.pdf";
                    saveDialog.Title = "Save Venue Allocation Report";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string outputPath = saveDialog.FileName;

                        using (MySqlConnection conn = new MySqlConnection("server=localhost;database=MidProjectDb;uid=root;pwd=Vat02842@Vat02842@;"))
                        {
                            conn.Open();
                            string query = @"SELECT e.event_name AS 'Event Name',e.description AS 'Event Description', v.venue_name AS 'Venue Name',v.location AS 'Location',vl.assigned_date AS 'Date',vl.assigned_time AS 'Time' FROM venues v JOIN venue_allocations vl ON v.venue_id = vl.venue_id JOIN itec_events e ON vl.event_id = e.event_id";
                            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            using (Document doc = new Document(PageSize.A4.Rotate()))
                            {
                                PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));
                                doc.Open();
                                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                                Paragraph title = new Paragraph("Venue Allocation Report\n\n", titleFont);
                                title.Alignment = Element.ALIGN_CENTER;
                                doc.Add(title);
                                PdfPTable table = new PdfPTable(dt.Columns.Count);
                                table.WidthPercentage = 100;
                                table.SpacingBefore = 10f;
                                table.SpacingAfter = 10f;
                                foreach (DataColumn col in dt.Columns)
                                {
                                    PdfPCell header = new PdfPCell(new Phrase(col.ColumnName,
                                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                                    header.BackgroundColor = new BaseColor(220, 220, 220);
                                    header.HorizontalAlignment = Element.ALIGN_CENTER;
                                    table.AddCell(header);
                                }
                                foreach (DataRow row in dt.Rows)
                                {
                                    foreach (object item in row.ItemArray)
                                    {
                                        table.AddCell(new Phrase(item?.ToString() ?? "",
                                            FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                                    }
                                }

                                doc.Add(table);
                            }

                            MessageBox.Show($"Venue report saved successfully!\n{outputPath}",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            System.Diagnostics.Process.Start(outputPath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating venue report: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}