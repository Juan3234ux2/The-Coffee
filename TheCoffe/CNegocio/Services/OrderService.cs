using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.CNegocio.Services
{
    class OrderService
    {
        private readonly PedidoRepository _orderRepository = new PedidoRepository();
        private readonly PedidoDetalleRepository _orderDetailRepository = new PedidoDetalleRepository();
        private readonly ProductService _productService = new ProductService();
        private readonly TableService _tableService = new TableService();
        public async Task<List<Venta>> ObtenerPedidosActivos()
        {
            return await _orderRepository.Read("En Preparacion");
        }
        public async Task<List<Venta>> ObtenerPedidosCompletados()
        {
            return await _orderRepository.Read("Completado");
        }
        public async Task<List<Venta>> BuscarPedidoPorMesero(string nombreMesero, int id_turno)
        {
            return await _orderRepository.SearchbyWaiter(nombreMesero, id_turno);
        }
        public async Task<List<Venta_Detalle>> ObtenerDetallesDeUnPedido(int idPedido)
        {
            return await _orderRepository.ObtenerDetallesPedido(idPedido);
        }
        public async Task<List<Venta_Detalle>> ObtenerTodosLosDetalles()
        {
            return await _orderDetailRepository.Read();
        }
        public async Task<List<Venta>> FiltrarPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            return await _orderRepository.FiltrarPorFecha(fechaDesde, fechaHasta);
        }
        public bool HayPedidosActivos()
        {
            return _orderRepository.HayPedidosActivos();
        }
        public void CancelarPedido(Venta pedido)
        {
            try
            {
                _orderRepository.CancelOrder(pedido);
                _tableService.CambiarDisponibilidad(pedido.id_mesa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Venta>> ObtenerTodosLosPedidos()
        {
            return await _orderRepository.FindAll();
        }
        public Venta ObtenerPedidoPorID(int id)
        {
            return _orderRepository.SearchObject(id);
        }
        public Venta_Detalle ObtenerDetallePorID(int id)
        {
            return _orderDetailRepository.SearchObject(id);
        }
        public Venta_Detalle ObtenerUltimoDetalle()
        {
            return _orderDetailRepository.GetLastRecord();
        }
        public void EliminarDetalle(Venta_Detalle detalle)
        {
            try
            {
                _orderDetailRepository.EliminarDetalle(detalle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void FinalizarPedido(Venta venta)
        {
            Venta pedido = venta;
            pedido.monto_total = pedido.Venta_Detalle.Sum(d => d.precio_unitario * d.cantidad);
            pedido.estado = "Completado";
            ActualizarPedido(pedido);
            _tableService.CambiarDisponibilidad(pedido.id_mesa);
        }
        public void CrearVenta(Venta pedido)
        {
            try
            {             
                _orderRepository.Create(pedido);
                _tableService.CambiarDisponibilidad(pedido.id_mesa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ActualizarPedido(Venta pedido)
        {
            try
            {
                _orderRepository.Update(pedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Venta> ObtenerVentaPorMesa(int idMesa)
        {
            return await _orderRepository.ObtenerVentaPorMesa(idMesa);
        }
        public bool AgregarProductoAlPedido(Venta pedido, int id_producto)
        {
            //El booleano indica si es un nuevo producto o si ya estaba agregado.
            Venta_Detalle detallePedido = _orderDetailRepository.ObtenerDetalle(pedido.id_ventas, id_producto);
            Producto producto = _productService.ObtenerProductoPorID(id_producto);
            bool estaAgregado = pedido.Venta_Detalle.Any(v => v.id_producto == id_producto);
            if (detallePedido != null)
            {
                ModificarCantidad(detallePedido.id_detalle, 1, producto.id_producto);
                ActualizarPedido(pedido);
                return false;
            }
            else
            {
                detallePedido = new Venta_Detalle
                {
                    id_ventas = pedido.id_ventas,
                    id_producto = id_producto,
                    precio_unitario = producto.precio,
                    cantidad = 1,
                    subtotal = producto.precio
                };
                _orderDetailRepository.Create(detallePedido);
                ActualizarPedido(pedido);
                return true;
            }
        }
        public void ModificarCantidad(int idDetalle, int cantidad, int idProducto)
        {
            Venta_Detalle detalle = ObtenerDetallePorID(idDetalle);
            Producto producto = _productService.ObtenerProductoPorID(idProducto);
            detalle.cantidad += cantidad;
            detalle.subtotal = producto.precio * detalle.cantidad;
            _orderDetailRepository.Update(detalle);
        }
    }
}
