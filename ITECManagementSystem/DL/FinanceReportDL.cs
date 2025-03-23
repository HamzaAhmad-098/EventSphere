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
        private class PdfPageEventHandler : PdfPageEventHelper
        {
            private readonly string _watermarkText;
            private readonly string _printDate;

            public PdfPageEventHandler(string watermark, string date)
            {
                _watermarkText = watermark;
                _printDate = date;
            }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                base.OnEndPage(writer, document);
                PdfContentByte canvas = writer.DirectContentUnder;
                BaseFont font = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED);
                PdfGState gState = new PdfGState { FillOpacity = 0.15f, StrokeOpacity = 0.15f };
                canvas.SetGState(gState);
                canvas.BeginText();
                canvas.SetFontAndSize(font, 48);
                canvas.SetRGBColorFill(180, 180, 180);
                canvas.ShowTextAligned(
                    Element.ALIGN_CENTER,
                    _watermarkText,
                    document.PageSize.Width / 2,
                    document.PageSize.Height / 2 + 20,
                    45
                );
                canvas.EndText();
                ColumnText.ShowTextAligned(
                    writer.DirectContent,
                    Element.ALIGN_RIGHT,
                    new Phrase(_printDate, FontFactory.GetFont(FontFactory.HELVETICA, 10)),
                    document.Right - 20,
                    document.Bottom + 20,
                    0
                );
            }
        }

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
                            string query = @"SELECT lp.value AS 'Transaction Type', f.date_recorded AS 'Date', f.amount AS 'Amount' FROM finances f JOIN lookup lp ON f.type_id = lp.lookup_id AND lp.category = 'FinanceTypes' ORDER BY f.date_recorded DESC;";
                            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            using (Document doc = new Document(PageSize.A4.Rotate()))
                            {
                                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));
                                writer.PageEvent = new PdfPageEventHandler("ITEC MANAGEMENT SYSTEM", DateTime.Now.ToString("dd MMMM yyyy HH:mm"));
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
                                    PdfPCell cell = new PdfPCell(new Phrase(col.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                                    cell.BackgroundColor = new BaseColor(200, 200, 200);
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    table.AddCell(cell);
                                }
                                foreach (DataRow row in dt.Rows)
                                {
                                    foreach (object item in row.ItemArray)
                                    {
                                        table.AddCell(new Phrase(item?.ToString() ?? "", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                                    }
                                }
                                doc.Add(table);
                            }
                            MessageBox.Show("Report saved successfully!\nLocation: " + outputPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            System.Diagnostics.Process.Start(outputPath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}