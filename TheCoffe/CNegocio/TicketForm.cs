using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace ticket
{
    public partial class TicketForm : Form
    {
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;

        public TicketForm()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            // Tamaño del papel para el ticket
            PaperSize ticketSize = new PaperSize("Ticket", 280, 500); // Ancho y alto en hundredths of an inch (1 in = 100 units)

            printDocument.DefaultPageSettings.PaperSize = ticketSize;
            printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0); // Sin márgenes

            // Configura el cuadro de vista previa de impresión
            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Width = 400; // Ajusta el ancho según el tamaño del ticket
            printPreviewDialog.Height = 600; // Ajusta la altura según el tamaño del ticket
        }

        private void ShowPrintPreview()
        {
            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la vista previa: {ex.Message}");
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Datos de prueba para el ticket
            string tiendaNombre = "The Coffee Shop";
            string direccion = "123 Coffee St., Bean City";
            string telefono = "(123) 456-7890";
            string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string cajero = "Juan Pérez";

            // Productos de prueba
            var productos = new[]
            {
                new { Nombre = "Café Americano", Cantidad = 2, Precio = 3.50 },
                new { Nombre = "Latte", Cantidad = 1, Precio = 4.75 },
                new { Nombre = "Muffin de Chocolate", Cantidad = 1, Precio = 2.00 }
            };

            // Total y otros datos
            double subtotal = 0;
            foreach (var producto in productos)
            {
                subtotal += producto.Cantidad * producto.Precio;
            }
            double impuesto = subtotal * 0.16; // Ejemplo de impuesto del 16%
            double total = subtotal + impuesto;

            // Formateo del contenido del ticket
            StringBuilder ticketContent = new StringBuilder();
            ticketContent.AppendLine(tiendaNombre);
            ticketContent.AppendLine(direccion);
            ticketContent.AppendLine("Tel: " + telefono);
            ticketContent.AppendLine(new string('-', 30));
            ticketContent.AppendLine("Fecha: " + fecha);
            ticketContent.AppendLine("Cajero: " + cajero);
            ticketContent.AppendLine(new string('-', 30));
            ticketContent.AppendLine("Cant.  Producto           Precio");

            foreach (var producto in productos)
            {
                ticketContent.AppendLine($"{producto.Cantidad}    {producto.Nombre.PadRight(15)} ${producto.Precio * producto.Cantidad:F2}");
            }

            ticketContent.AppendLine(new string('-', 30));
            ticketContent.AppendLine($"Subtotal:        ${subtotal:F2}");
            ticketContent.AppendLine($"Impuesto (16%):  ${impuesto:F2}");
            ticketContent.AppendLine($"Total:           ${total:F2}");
            ticketContent.AppendLine(new string('-', 30));

            e.Graphics.DrawString(ticketContent.ToString(), new Font("Courier New", 10), Brushes.Black, new PointF(10, 10));
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ShowPrintPreview();
        }
    }
}
