using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;
using TheCoffe.CDatos.Estadisticas;

namespace TheCoffe.CNegocio.Services
{
    class AdminService
    {
        DBTheCoffeeEntities db;
        private OrderService orderService = new OrderService();
        private CategoriaRepository categoriaRepository = new CategoriaRepository();
        public async Task<List<CategoriaEstadistica>> ObtenerVentasPorCategoria(DateTime fechaDesde, DateTime fechaHasta)
        {
            return await categoriaRepository.ObtenerVentasPorCategoria(fechaDesde, fechaHasta);
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
            {
                List<Venta> ventas = await orderService.FiltrarPorFecha(fechaDesde, fechaHasta);
                int diasEnRango = (fechaHasta - fechaDesde).Days + 1;

                var pedidosAgrupados = new List<IngresoDiario>();

                if (diasEnRango <= 8)
                {
                    pedidosAgrupados = ventas
                        .GroupBy(v => v.fecha_venta?.Date)
                        .Select(g => new IngresoDiario
                        {
                            Periodo = g.Key.Value.ToShortDateString(),
                            Recaudado = g.Sum(v => v.monto_total ?? 0)
                        })
                        .OrderBy(g => g.Periodo)
                        .ToList();
                }
                else if (diasEnRango <= 50)
                {
                    pedidosAgrupados = ventas
                        .GroupBy(v => new { Año = v.fecha_venta?.Year, Semana = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(v.fecha_venta.Value, CalendarWeekRule.FirstDay, DayOfWeek.Monday) })
                        .Select(g => new IngresoDiario
                        {
                            Periodo = $"Semana {g.Key.Semana} de {g.Key.Año}",
                            Recaudado = g.Sum(v => v.monto_total ?? 0)
                        })
                        .OrderBy(g => g.Periodo)
                        .ToList();
                }
                else
                {
                    pedidosAgrupados = ventas
                        .GroupBy(v => new { Año = v.fecha_venta?.Year, Mes = v.fecha_venta?.Month })
                        .Select(g => new IngresoDiario
                        {
                            Periodo = $"{g.Key.Mes}/{g.Key.Año}",
                            Recaudado = g.Sum(v => v.monto_total??0)
                        })
                        .OrderBy(g => g.Periodo)
                        .ToList();
                }

                return pedidosAgrupados;
            }

        }

        public async Task<InfoDashboard> ObtenerCantidadesDashboard()
        {
            using(db = new DBTheCoffeeEntities())
            {
                List<Venta> ventasHoy = await orderService.FiltrarPorFecha(DateTime.Now, DateTime.Now);
                double recaudadoHoy = 0;
                if(ventasHoy.Count > 0)
                {
                    recaudadoHoy = ventasHoy.GroupBy(v => v.fecha_venta ?? DateTime.Now).Select(r => r.Sum(v => v.monto_total ?? 0)).First();
                }
                return new InfoDashboard
                {
                    CantidadProductos = db.Producto.Where(p => p.estado).Count(),
                    TotalRecaudado = recaudadoHoy,
                    TotalMeseros = db.Mesero.Where(m => m.estado).Count(),
                    TotalPedido = db.Venta.Where(v => DbFunctions.TruncateTime(v.fecha_venta) == DbFunctions.TruncateTime(DateTime.Now)).Count()
                };
            }
        }
        public async Task<List<TotalPedidoEstadistica>> ObtenerPedidosAgrupados(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Venta> ventas = await orderService.FiltrarPorFecha(fechaDesde, fechaHasta);
            int diasEnRango = (fechaHasta - fechaDesde).Days + 1;

            var pedidosAgrupados = new List<TotalPedidoEstadistica>();

            if (diasEnRango <= 8)
            {
                pedidosAgrupados = ventas
                    .GroupBy(v => v.fecha_venta?.Date)
                    .Select(g => new TotalPedidoEstadistica
                    {
                        Periodo = g.Key.Value.ToShortDateString(),
                        CantidadPedidos = g.Count()
                    })
                    .OrderBy(g => g.Periodo)
                    .ToList();
            }
            else if (diasEnRango <= 50)
            {
                pedidosAgrupados = ventas
                    .GroupBy(v => new { Año = v.fecha_venta?.Year, Semana = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(v.fecha_venta.Value, CalendarWeekRule.FirstDay, DayOfWeek.Monday) })
                    .Select(g => new TotalPedidoEstadistica
                    {
                        Periodo = $"Semana {g.Key.Semana} de {g.Key.Año}",
                        CantidadPedidos = g.Count()
                    })
                    .OrderBy(g => g.Periodo)
                    .ToList();
            }
            else
            {
                pedidosAgrupados = ventas
                    .GroupBy(v => new { Año = v.fecha_venta?.Year, Mes = v.fecha_venta?.Month })
                    .Select(g => new TotalPedidoEstadistica
                    {
                        Periodo = $"{g.Key.Mes}/{g.Key.Año}",
                        CantidadPedidos = g.Count()
                    })
                    .OrderBy(g => g.Periodo)
                    .ToList();
            }

            return pedidosAgrupados;
        }

    }
}
