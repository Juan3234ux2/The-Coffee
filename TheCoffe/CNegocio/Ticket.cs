using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CDatos;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CNegocio
{
    class Ticket
    {
        private ProductService productService = new ProductService();
        public double CalcularTotal(Venta venta)
        {
            return venta.Venta_Detalle.Sum(d => d.subtotal);
        }
        public double CalcularVuelto(Venta venta, double recibido)
        {
            return recibido - CalcularTotal(venta);
        }
        public void CrearTicket(Venta venta, PrintPageEventArgs e, double recibido)
        {
            Graphics graphics = e.Graphics;
            Font h1 = new Font("Roboto", 14);
            Font h2 = new Font("Roboto Medium", 10.5f);
            Font h3 = new Font("Roboto", 10);
            float lineHeight = 20;
            float pageWidth = e.PageBounds.Width;
            float x = 5;
            float y = 10;

            // Datos de la tienda
            graphics.DrawString("The Coffee", h3, Brushes.Black, x, y); y += lineHeight;
            graphics.DrawString("CUIT: 2045759514", h3, Brushes.Black, x, y); y += lineHeight;
            graphics.DrawString("Ing. Brutos: 9053020001", h3, Brushes.Black, x, y); y += lineHeight;
            AgregarTextoAlCentro(graphics, h2, "TheCoffee S.R.L", x, y, pageWidth);
            y += lineHeight;
            AgregarTextoAlCentro(graphics, h2, "JR Vidal 1676", x, y, pageWidth);
            y += lineHeight;
            AgregarTextoAlCentro(graphics, h2, "Corrientes - Capital", x, y, pageWidth);
            y += lineHeight;
            AgregarTextoAlCentro(graphics, h2, "------------------------", x, y, pageWidth);
            y += lineHeight;
            graphics.DrawString("IVA Responsable Inscripto", h3, Brushes.Black, x, y); y += lineHeight;
            AgregarTextoAlCentro(graphics, h3, "A CONSUMIDOR FINAL", x, y, pageWidth);
            y += lineHeight;

            y += lineHeight;
            graphics.DrawString($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}", h3, Brushes.Black, x, y);
            AgregarTextoALaDerecha(graphics, h3, "Hora: " + DateTime.Now.ToString("HH:mm:ss"), x, y, pageWidth);
            y += lineHeight * 2;
            foreach (var detalle in venta.Venta_Detalle)
            {
                Producto producto = productService.ObtenerProductoPorID(detalle.id_producto);
                string nombreProducto = producto.nombre;
                string cantidad = detalle.cantidad.ToString();
                string precioUnitario = detalle.precio_unitario.ToString("C");
                string precioTotal = (detalle.cantidad * detalle.precio_unitario).ToString("C");

                graphics.DrawString($" ({cantidad} x {precioUnitario})", h3, Brushes.Black, x, y);
                y += lineHeight;
                graphics.DrawString($"{nombreProducto}", h3, Brushes.Black, x, y);
                AgregarTextoALaDerecha(graphics, h3, precioTotal, x, y, pageWidth);
                y += lineHeight;
            }
            y += lineHeight * 2;
            graphics.DrawString("TOTAL:", h2, Brushes.Black, x, y);
            AgregarTextoALaDerecha(graphics, h2, CalcularTotal(venta).ToString("C"), 10, y, pageWidth);
            y += lineHeight;
            graphics.DrawString("RECIBI(MOS):", h3, Brushes.Black, x, y);
            AgregarTextoALaDerecha(graphics, h3, recibido.ToString("C"), x,y,pageWidth);
            y += lineHeight;
            graphics.DrawString("CAMBIO:", h2, Brushes.Black, x, y);
            AgregarTextoALaDerecha(graphics, h2, CalcularVuelto(venta,recibido).ToString("C"), 10, y, pageWidth);
            y += lineHeight;
            graphics.DrawString($"Articulos: {venta.Venta_Detalle.Count.ToString()}", h3, Brushes.Black, x, y); y += lineHeight;
            graphics.DrawString($"Cajero: {AuthUser.Usuario.nombreCompleto}", h3, Brushes.Black, x, y); y += lineHeight * 4;
        }
        public void AgregarTextoALaDerecha(Graphics g,Font font, String texto, float x, float y,float ancho)
        {
            SizeF tamaño = g.MeasureString(texto, font);
            float xTexto = ancho - tamaño.Width - x;
            g.DrawString(texto, font, Brushes.Black, xTexto, y);
        }
        public void AgregarTextoAlCentro(Graphics g, Font font, String texto, float x, float y, float ancho)
        {
            SizeF tamaño = g.MeasureString(texto, font);
            float xTexto = (ancho - tamaño.Width) / 2;
            g.DrawString(texto, font, Brushes.Black, xTexto, y);
        }
    }
}
