using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms; 

namespace ITECManagementSystem.DL
{
    internal class FinanceReportDL
    {
        public void GenerateFinanceReport()
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveDialog.FileName = "FinanceReport.pdf"; 
                    saveDialog.Title = "Save Finance Report";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string outputPath = saveDialog.FileName;
                        using (MySqlConnection conn = new MySqlConnection("server=localhost;database=MidProjectDb;uid=root;pwd=Vat02842@Vat02842@;"))
                        {
                            conn.Open();
                            string query = @"SELECT lp.value AS 'Transaction Type', f.date_recorded AS 'Date',f.amount AS 'Amount' FROM finances f JOIN lookup lp ON f.type_id = lp.lookup_id AND lp.category = 'FinanceTypes'ORDER BY f.date_recorded DESC;";
                            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            using (Document doc = new Document(PageSize.A4.Rotate()))
                            {
                                PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));
                                doc.Open();
                                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                                Paragraph title = new Paragraph("ITEC Financial Report\n\n", titleFont);
                                title.Alignment = Element.ALIGN_CENTER;
                                doc.Add(title);
                                PdfPTable table = new PdfPTable(dt.Columns.Count);
                                table.WidthPercentage = 100;
                                table.SpacingBefore = 10f;
                                table.SpacingAfter = 10f;
                                foreach (DataColumn col in dt.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(col.ColumnName,
                                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                                    cell.BackgroundColor = new BaseColor(200, 200, 200);
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    table.AddCell(cell);
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

                            MessageBox.Show("Report saved successfully!\nLocation: " + outputPath,
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
                MessageBox.Show($"Error generating report: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}