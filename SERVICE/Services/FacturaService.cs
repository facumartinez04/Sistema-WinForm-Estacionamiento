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


namespace SERVICE.Services
{
    public static class FacturaService
    {

        public static void GenerarFactura(Factura factura)
        {
            try
            {
                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont regularFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                string filePath = $"Factura_{factura.idFactura}.pdf";

                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Encabezado
                        document.Add(new Paragraph("FACTURA - ESTACIONAMIENTO")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(18)
                            
                            .SetFontColor(ColorConstants.BLUE));

                        document.Add(new Paragraph("\n"));

                        // ID de Factura
                        document.Add(new Paragraph($"ID de Factura: {factura.idFactura}"));

                        // Datos del ingreso
                        document.Add(new Paragraph($"Fecha de Entrada: {factura.ingreso.fechaIngreso:dd/MM/yyyy HH:mm}"));
                        document.Add(new Paragraph($"Tipo de Tarifa: {factura.ingreso.objTipoTarifa.descripcion}"));

                        // Método de pago y monto total
                        document.Add(new Paragraph($"Método de Pago: {factura.metodoPago.descripcion}")).SetFont(boldFont);


                        document.Add(new Paragraph($"Monto Total: ${factura.monto_total}").SetFont(boldFont));



                        // Fecha de Salida
                        document.Add(new Paragraph($"Fecha de Salida: {factura.ingreso.fechaEgreso:dd/MM/yyyy HH:mm}"));

                        document.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   

    }
}
