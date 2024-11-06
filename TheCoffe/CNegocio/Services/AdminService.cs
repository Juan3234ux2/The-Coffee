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
            List<Venta> ventas = await orderService.FiltrarPorFecha(fechaDesde, fechaHasta);
            List<Venta_Detalle> detalles = new List<Venta_Detalle>();
            foreach (Venta_Detalle venta in ventas.SelectMany(p => p.Venta_Detalle).ToList())
            {
                var detalle = orderService.ObtenerDetallePorID(venta.id_detalle);
                detalles.Add(detalle);
            }
            var categoriasPopulares = detalles
                                      .Where(pd => pd.Producto.Categoria1 != null)
                                      .GroupBy(pd => pd.Producto.Categoria1.descripcion)
                                      .Select(g => new CategoriaEstadistica
                                      {
                                         TotalPedidos = g.Count(),
                                         Categoria = g.Key
                                      })
                                      .OrderByDescending(t => t.TotalPedidos)
                                      .Take(3)
                                      .ToList();
              return categoriasPopulares;            
        }
        public async Task<double> ObtenerPromedioIngresosDiarios(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Venta> ventas = await orderService.FiltrarPorFecha(fechaDesde, fechaHasta);
            var totalRecaudado = ventas.Sum(v => v.monto_total??0);
            int diasEnRango = (fechaHasta - fechaDesde).Days + 1;
            double promedioDiario = diasEnRango > 0 ? totalRecaudado / diasEnRango : 0;
            return promedioDiario;
        }
        public async Task<int> ObtenerPromedioCantidadVentas(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Venta> ventas = await orderService.FiltrarPorFecha(fechaDesde, fechaHasta);
            int diasEnRango = (fechaHasta - fechaDesde).Days + 1;
            int promedioCantidad = diasEnRango > 0 ? ventas.Count() / diasEnRango : 0;
            return promedioCantidad;
        }
        public async Task<List<IngresoDiario>> ObtenerTotalRecaudado(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Venta> ventas = await orderService.FiltrarPorFecha(fechaDesde, fechaHasta);
            int diasEnRango = (fechaHasta - fechaDesde).Days;
            var ingresosReales = ventas
                                  .GroupBy(v => ObtenerGrupoDeFecha(v.fecha_venta ?? DateTime.Now, diasEnRango))
                                  .Select(g => new IngresoDiario
                                  {
                                      Fecha = g.Key,
                                      Recaudado = g.Sum(v => v.monto_total ?? 0)
                                  })
                                  .ToDictionary(v => v.Fecha , v => v.Recaudado);
            var listaCompletaIngresos = new List<IngresoDiario>();

            for(var fecha = fechaDesde.Date; fecha <= fechaHasta.Date; fecha = fecha.AddDays(1))
            {
                listaCompletaIngresos.Add(new IngresoDiario
                {
                    Fecha = fecha,
                    Recaudado = ingresosReales.ContainsKey(fecha) ? ingresosReales[fecha] : 0
                });
            }
            return listaCompletaIngresos;
        }
        private DateTime ObtenerGrupoDeFecha(DateTime fecha, int rangoDias)
        {
            if(rangoDias <= 7)
            {
                return fecha.Date;
            }else if(rangoDias <= 30)
            {
                return fecha.AddDays(-(int)fecha.DayOfWeek).Date;
            }
            else
            {
                return new DateTime(fecha.Year, fecha.Month,1);
            }
        }
    }
}
