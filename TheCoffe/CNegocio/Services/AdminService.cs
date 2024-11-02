using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CDatos;

namespace TheCoffe.CNegocio.Services
{
    class AdminService
    {
        private OrderService orderService = new OrderService();
        public async Task<List<CategoriaEstadistica>> ObtenerVentasPorCategoria(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                List<Venta> ventas = await orderService.FiltrarPorFecha(fechaDesde, fechaHasta);
                var categoriasPopulares = ventas.SelectMany(v => v.Venta_Detalle)
                                          .Where(pd => pd.Producto.Categoria1 != null)
                                          .GroupBy(pd => pd.Producto.Categoria1)
                                          .Select(g => new CategoriaEstadistica
                                          {
                                              TotalPedidos = g.Count(),
                                              Categoria = g.Key.descripcion
                                          }).ToList();

                return categoriasPopulares;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
