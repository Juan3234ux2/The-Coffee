using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.CNegocio.Services
{
    class CategoryService
    {
        private readonly CategoriaRepository _categoryRepository = new CategoriaRepository();
        public async Task<List<Categoria1>> ObtenerCategoriasActivas()
        {
            return await _categoryRepository.Read(true);
        }
        public async Task<List<Categoria1>> ObtenerCategoriasEliminadas()
        {
            return await _categoryRepository.Read(false);
        }
        public Categoria1 ObtenerCategoriaPorID(int id)
        {
            return _categoryRepository.SearchObject(id);
        }
        public void EliminarCategoria(int id)
        {
            try
            {
                _categoryRepository.Delete(id); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Categoria1> BuscarPorNombre(String nombre)
        {
            return _categoryRepository.Search(nombre);
        }
        public void CrearCategoria(Categoria1 categoria)
        {
            try
            {
                if (_categoryRepository.existCategory(categoria))
                {
                    throw new Exception("La categoria ya existe");
                }
                else
                {
                    _categoryRepository.Create(categoria);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ActualizarCategoria(Categoria1 categoria)
        {
            try
            {
                if (_categoryRepository.existCategory(categoria))
                {
                    throw new Exception("Ya existe una categoria con este nombre");
                }
                else
                {
                    _categoryRepository.Update(categoria);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
