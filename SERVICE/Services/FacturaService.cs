using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using SERVICE.Domain;


namespace SERVICE.Services
{
    public static class FacturaService 
    {


        public static void GenerarFactura(Factura factura)
        {
            try
            {
                



                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"{LanguageManager.Translate("generate-ticket-success").ToString()} {factura.ingreso.vehiculo.patente}"));


                string carpetaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Facturas");
                Directory.CreateDirectory(carpetaDestino);


                string filePath = Path.Combine(carpetaDestino, $"Factura_{factura.idFactura}.pdf");

                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                PdfFont regularFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                using (PdfWriter writer = new PdfWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None)))


                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    document.SetMargins(10, 10, 10, 10);

                    document.Add(new Paragraph($"🅿 {LanguageManager.Translate("parking").ToString()}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(14)
                        .SetFontColor(ColorConstants.BLACK)
                        .SetFont(boldFont));

                    document.Add(new Paragraph($"{LanguageManager.Translate("payment-ticket").ToString()}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(12)
                        .SetFont(boldFont));

                    document.Add(new Paragraph("\n"));

                    document.Add(new Paragraph($"{LanguageManager.Translate("id-invoice").ToString()}: {factura.idFactura}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(regularFont));

                    document.Add(new Paragraph($"{LanguageManager.Translate("patent").ToString()}: {factura.ingreso?.vehiculo.patente ?? "N/A"}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(regularFont));

                    document.Add(new Paragraph($"{LanguageManager.Translate("date-and-hour-joined").ToString()}: {factura.ingreso?.fechaIngreso:dd/MM/yyyy HH:mm}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(regularFont));

                    document.Add(new Paragraph($"{LanguageManager.Translate("date-and-hour-exited").ToString()}: {factura.ingreso?.fechaEgreso:dd/MM/yyyy HH:mm}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(regularFont));

                    document.Add(new Paragraph($"{LanguageManager.Translate("payment-method").ToString()}: {factura.metodoPago?.descripcion ?? "N/A"}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(boldFont));

                    document.Add(new Paragraph($"{LanguageManager.Translate("total-mount").ToString()}: ${factura.monto_total}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(12)
                        .SetFont(boldFont));

                    document.Add(new Paragraph("\n"));

                    document.Add(new Paragraph("|| || || || || || || || || || || ||")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(boldFont));

                    document.Add(new Paragraph($"¡{LanguageManager.Translate("thanks-you-for-your-visit").ToString()}!")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(regularFont));

                    document.Add(new Paragraph($"{LanguageManager.Translate("driving-warning").ToString()}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(regularFont));

                }

                if (File.Exists(filePath))
                {
                    MessageBox.Show($"{LanguageManager.Translate("invoice-success").ToString()} :\n{filePath}", $"{LanguageManager.Translate("invoice-generated").ToString()}", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show($"Error: {LanguageManager.Translate("pdf-dont-generate-success").ToString()}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"{LanguageManager.Translate("error-to-generate-a-file").ToString()}:\n{ex.Message}", "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{LanguageManager.Translate("error-to-generate-a-invoice").ToString()}:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
