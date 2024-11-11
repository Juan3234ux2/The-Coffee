using PdfSharp.Pdf;
using PdfSharp.Drawing;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.Diagnostics;
using QRCoder;
using System.IO;
using System.Drawing.Imaging;
using System;
using TheCoffe.CDatos;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CNegocio
{
    public class Factura
    {
        private ProductService productService = new ProductService();
        public void CrearFactura(Venta venta, Cliente cliente)
        {
            // Crear un documento de MigraDoc
            var document = new Document();
            document.Info.Title = "Factura";
            var factura = document.AddSection();
            factura.PageSetup.PageFormat = PageFormat.A4;
            factura.PageSetup.LeftMargin = "0.35cm";
            factura.PageSetup.RightMargin = "0.35cm";
            factura.PageSetup.TopMargin = 22;
            factura.PageSetup.BottomMargin = 5;
            // Encabezado
            var titulo = factura.AddParagraph();
            titulo.Format.Alignment = ParagraphAlignment.Center;
            titulo.Format.Font.Size = 16;
            titulo.AddFormattedText("FACTURA", TextFormat.Bold);
            titulo.AddLineBreak();

            // Información de la empresa
            var headerTable = factura.AddTable();
            headerTable.Borders.Visible = false;
            var logoColumn = headerTable.AddColumn("4.5cm");
            var textColumn = headerTable.AddColumn("8cm");
            var headerRow = headerTable.AddRow();
            var empresaParrafo = headerRow.Cells[1].AddParagraph();
            var logoImage = headerRow.Cells[0].AddParagraph().AddImage("base64:" + GenerarImagenLogo());
            logoImage.Width = "4.5cm";
            logoImage.LockAspectRatio = true;
            empresaParrafo.Format.SpaceBefore = "0.7cm";
            empresaParrafo.Format.Alignment = ParagraphAlignment.Left;
            empresaParrafo.Format.Font.Size = 10;
            empresaParrafo.Format.LeftIndent = "0.5cm";
            empresaParrafo.AddText("Razón Social: TheCoffee");
            empresaParrafo.AddLineBreak();
            empresaParrafo.AddText("Domicilio: Sarmiento 127 - Corrientes");
            empresaParrafo.AddLineBreak();
            empresaParrafo.AddText("Teléfono: 3782452892");
            empresaParrafo.AddLineBreak();
            empresaParrafo.AddText("CUIT: 20-33333333-1");
            empresaParrafo.AddLineBreak();
            empresaParrafo.AddText("Ingresos Brutos: IIBBXX");
            empresaParrafo.AddLineBreak();
            empresaParrafo.AddText("Condición IVA: Responsable Inscripto");
            empresaParrafo.AddLineBreak();
            empresaParrafo.Format.SpaceAfter = "0.5cm";
            empresaParrafo.Format.LineSpacingRule = LineSpacingRule.OnePtFive;
            //Linea horizontal
            var line = factura.AddParagraph();
            line.Format.Alignment = ParagraphAlignment.Center;
            line.AddText("\n");
            line.Format.Borders.Top.Width = 2;
            line.Format.Borders.Top.Color = Colors.Black;
            // Información del cliente
            var clienteParrafo = factura.AddParagraph();
            clienteParrafo.Format.LeftIndent = "0.5cm";
            clienteParrafo.Format.SpaceBefore = "0.10cm";
            clienteParrafo.Format.LineSpacing = "0.8cm";           
            clienteParrafo.AddText($"Apellido y Nombre / Razón Social: {cliente.apellido}, {cliente.nombre}");
            clienteParrafo.AddLineBreak();
            clienteParrafo.AddText($"CUIT: {cliente.cuit}");
            clienteParrafo.AddLineBreak();
            clienteParrafo.AddText($"Domicilio: {cliente.domicilio}, Localidad: {cliente.localidad}");
            clienteParrafo.AddLineBreak();
            clienteParrafo.AddText($"Provincia: {cliente.provincia}");
            clienteParrafo.AddLineBreak();
            clienteParrafo.Format.SpaceAfter = "0.4cm";
            clienteParrafo.Format.LineSpacingRule = LineSpacingRule.OnePtFive;
            //Linea horizontal
            line = factura.AddParagraph();
            line.Format.Alignment = ParagraphAlignment.Center;
            line.AddText("\n");
            line.Format.Borders.Top.Width = 2;
            line.Format.Borders.Top.Color = Colors.Black;
            // Tabla de detalles
            var table = factura.AddTable();
            table.Borders.Width = 0.25;
            table.Rows.Height = 20;
            table.Borders.Color = Colors.Black;
            table.Rows.LeftIndent = 13;

            // Definir columnas de la tabla
            var producto = table.AddColumn("10.3cm");
            var cantidad = table.AddColumn("2cm");
            var subtotal = table.AddColumn("3cm");
            var total = table.AddColumn("4cm");
            producto.Format.Alignment = ParagraphAlignment.Left;
            cantidad.Format.Alignment = ParagraphAlignment.Center;
            subtotal.Format.Alignment = ParagraphAlignment.Center;
            total.Format.Alignment = ParagraphAlignment.Right;

            // Fila de encabezado de tabla
            var row = table.AddRow();
            row.Cells[0].AddParagraph("PRODUCTO");
            row.Cells[1].AddParagraph("CANT.");
            row.Cells[2].AddParagraph("PRECIO UN.");
            row.Cells[3].AddParagraph("SUBTOTAL");
            row.Format.Font.Bold = true;
            foreach (Cell cell in row.Cells)
            {
                cell.VerticalAlignment = VerticalAlignment.Center;
            }
            // Agregar filas con datos
            foreach(var detalle in venta.Venta_Detalle)
            {
                row = table.AddRow();
                Producto product = productService.ObtenerProductoPorID(detalle.id_producto);
                row.Cells[0].AddParagraph(product.nombre);
                row.Cells[1].AddParagraph(detalle.cantidad.ToString());
                row.Cells[2].AddParagraph(detalle.precio_unitario.ToString("C"));
                row.Cells[3].AddParagraph(detalle.subtotal.ToString("C"));
                foreach (Cell cell in row.Cells)
                {
                    cell.VerticalAlignment = VerticalAlignment.Center;
                }
            }
            // Datos del footer de la factura
            var footer = factura.Footers.Primary;
            // Linea Horizontal
            line = footer.AddParagraph();
            line.Format.Alignment = ParagraphAlignment.Center;
            line.AddText("\n");
            line.Format.Borders.Top.Width = 2;
            line.Format.Borders.Top.Color = Colors.Black;
            //Monto total de la factura
            var montoTotal = footer.AddParagraph();
            montoTotal.Format.SpaceBefore = "0.3cm";
            montoTotal.AddText("Total: ");           
            montoTotal.AddFormattedText($"{venta.monto_total?.ToString("C")}", TextFormat.Bold);
            montoTotal.Format.Font.Size = 12;
            montoTotal.Format.Alignment = ParagraphAlignment.Right;
            montoTotal.Format.RightIndent = 20;
            montoTotal.AddLineBreak();
            //Informacion fiscal y qr
            var infoTable = footer.AddTable();
            infoTable.Borders.Visible = false;
            var qrColumn = infoTable.AddColumn("3.5cm");
            textColumn = infoTable.AddColumn("7cm");
            var infoRow = infoTable.AddRow();
            //QR
            var qrImage = infoRow.Cells[0].AddParagraph().AddImage("base64:" + GenerarQR());
            qrImage.Width = "3.5cm";
            qrImage.LockAspectRatio = true;
            //Texto al lado del qr sobre informacion fiscal
            var infoText = infoRow.Cells[1].AddParagraph();
            infoText.AddText("ORIGINAL");
            infoText.AddLineBreak();          
            infoText.AddFormattedText($"Fecha de Vto. CAE: {venta.fecha_venta?.ToShortDateString()}", TextFormat.Bold);
            infoText.AddLineBreak();
            infoText.AddFormattedText($"CAE N°: {venta.id_ventas}", TextFormat.Bold);
            infoText.Format.Font.Size = 10;
            infoText.Format.SpaceBefore = "0.9cm";
            infoText.Format.LeftIndent = "0.4cm";
            infoText.Format.LineSpacingRule = LineSpacingRule.OnePtFive;
            //Codigo que renderiza el pdf
#pragma warning disable CS0618 
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true)
            {
                Document = document
            };
#pragma warning restore CS0618 
            pdfRenderer.RenderDocument();
            PdfDocument pdfDocument = pdfRenderer.PdfDocument;
            //Codigo que genera las lineas de los margenes
            foreach (PdfPage page in pdfDocument.Pages)
            {
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XPen blackPen = new XPen(XColors.Black, 2);
#pragma warning disable CS0618
                gfx.DrawRectangle(blackPen, 10, 10, page.Width - 20, page.Height - 20);
#pragma warning restore CS0618
            }
            // Guardar el PDF
            var filename = "FacturaVenta.pdf";
            pdfRenderer.PdfDocument.Save(filename);
            Process.Start(filename);
        }

        private string GenerarQR()
        {
            var qrGenerator = new QRCodeGenerator();
            var qrData = qrGenerator.CreateQrCode("https://thecoffee.com/", QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrData);

            string base64Image;
            using (var bitmap = qrCode.GetGraphic(20)) 
            using (var ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                base64Image = Convert.ToBase64String(ms.ToArray());
            }
            return base64Image;
        }
        private string GenerarImagenLogo()
        {
            string base64Image;
            using (var ms = new MemoryStream())
            {
                Properties.Resources.TheCoffeeLogo.Save(ms, ImageFormat.Png);
                base64Image = Convert.ToBase64String(ms.ToArray());
            }
            return base64Image;
        }
    }

}
