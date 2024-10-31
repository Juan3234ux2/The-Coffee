using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.CNegocio.Services
{
    class ProductService
    {
        private ProductoRepository _productRepository = new ProductoRepository();
        public string FormatCurrency(double price)
        {
            return string.Format("{0:n}", price);
        }
        public async Task<List<Producto>> ObtenerProductosActivos()
        {
            return await _productRepository.Read(true);
        }
        public async Task<List<Producto>> ObtenerProductosPörCategoria(string nombreCategoria)
        {
            return await _productRepository.GetProductsByCategory(nombreCategoria);
        }
        public async Task<List<Producto>> ObtenerProductosEliminados()
        {
            return await _productRepository.Read(false);
        }
        public Producto ObtenerProductoPorID(int id)
        {
            return _productRepository.SearchObject(id);
        }
        public void CambiarEstado(int id)
        {
            _productRepository.ChangeState(id);
        }
        public List<Producto> BuscarPorNombre(string nombre)
        {
            return _productRepository.Search(nombre);
        }
        public void CrearProducto(Producto producto)
        {
            try
            {
                if (ValidarDatos(producto))
                {
                    _productRepository.Create(producto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ActualizarProducto(Producto producto)
        {
            try
            {
                if (ValidarDatos(producto))
                {
                    _productRepository.Update(producto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ValidarDatos(Producto producto)
        {
            if (_productRepository.ExistProduct(producto))
            {
                throw new Exception("Ya existe un producto con este nombre");
            }
            else
            {
                return true;
            }
        }
    }
}
