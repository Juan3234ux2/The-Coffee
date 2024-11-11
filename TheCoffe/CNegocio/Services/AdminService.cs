using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

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
            List<Venta> ventas = await orderService.FiltrarPorFecha(fechaDesde, fechaHasta);
            int diasEnRango = (fechaHasta - fechaDesde).Days;
            return ventas
                   .GroupBy(v => ObtenerGrupoDeFecha(v.fecha_venta ?? DateTime.Now, diasEnRango))
                   .Select(g => new IngresoDiario
                   {
                       Fecha = g.Key,
                       Recaudado = g.Sum(v => v.monto_total ?? 0)
                   })
                   .ToList();

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
        public async Task<InfoDashboard> ObtenerCantidadesDashboard()
        {
            using(db = new DBTheCoffeeEntities())
            {
                List<Venta> ventasHoy = await orderService.FiltrarPorFecha(DateTime.Now, DateTime.Now);
                var recaudadoHoy = ventasHoy.GroupBy(v => v.fecha_venta ?? DateTime.Now).Select(r => r.Sum(v => v.monto_total ?? 0)).First();
                return new InfoDashboard
                {
                    CantidadProductos = db.Producto.Where(p => p.estado).Count(),
                    TotalRecaudado = recaudadoHoy,
                    TotalMeseros = db.Mesero.Where(m => m.estado).Count(),
                    TotalPedido = db.Venta.Where(v => DbFunctions.TruncateTime(v.fecha_venta) == DbFunctions.TruncateTime(DateTime.Now)).Count()
                };
            }
        }
    }
}
