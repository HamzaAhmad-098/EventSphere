using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ITECManagementSystem.DL
{
    internal class ParticipantReportDL
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
        public void GenerateParticipantReport()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=MidProjectDb;uid=root;pwd=Vat02842@Vat02842@;"))
                {
                    conn.Open();
                    string query = @"SELECT p.name AS Name, e.fee_amount, p.contact, i.event_name,l.value AS verification_Status, t.team_name FROM participants p LEFT JOIN event_participants e ON p.participant_id = e.participant_id JOIN itec_events i JOIN lookup l ON e.payment_status_id = l.lookup_id JOIN team_participants tp ON e.participant_id = tp.participant_id JOIN teams t ON tp.team_id = t.team_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    using (Document doc = new Document(PageSize.A4))
                    {
                        string outputPath = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                            "Participant_Report.pdf");

                        using (FileStream fs = new FileStream(outputPath, FileMode.Create))
                        {
                            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                            string printDate = DateTime.Now.ToString("dd MMMM yyyy HH:mm");
                            writer.PageEvent = new PdfPageEventHandler("ITEC MANAGEMENT SYSTEM", printDate);

                            doc.Open();
                            iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                            Paragraph title = new Paragraph("Participants Report\n\n", titleFont);
                            title.Alignment = Element.ALIGN_CENTER;
                            doc.Add(title);
                            PdfPTable table = new PdfPTable(dt.Columns.Count);
                            table.WidthPercentage = 100;
                            foreach (DataColumn column in dt.Columns)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName,
                                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                                headerCell.BackgroundColor = new BaseColor(200, 200, 200);
                                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(headerCell);
                            }
                            foreach (DataRow row in dt.Rows)
                            {
                                foreach (object cellData in row.ItemArray)
                                {
                                    table.AddCell(new Phrase(cellData.ToString(),
                                        FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                                }
                            }
                            doc.Add(table);
                            doc.Close();
                        }
                    }
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