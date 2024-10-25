using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.CNegocio.Services
{
    class TableService
    {
        private readonly MesaRepository _tableRepository = new MesaRepository();
        public async Task<List<Mesa>> ObtenerMesasActivas()
        {
            return await _tableRepository.Read(true);
        }
        public async Task<List<Mesa>> ObtenerMesasEliminadas()
        {
            return await _tableRepository.Read(false);
        }
        public Mesa ObtenerMesaPorID(int id)
        {
            return _tableRepository.SearchObject(id);
        }
        public void CambiarEstado(int id)
        {
            _tableRepository.ChangeState(id);
        }
        public List<Mesa> BuscarPorNro(int nroMesa)
        {
            return _tableRepository.Search(nroMesa);
        }
        public void CrearMesa(Mesa mesa)
        {
            try
            {
                if (_tableRepository.existTable(mesa))
                {
                    throw new Exception("Ya existe una mesa con ese número");
                }
                else
                {
                    _tableRepository.Create(mesa);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ActualizarMesa(Mesa mesa)
        {
            try
            {
                if (_tableRepository.existTable(mesa))
                {
                    throw new Exception("Ya existe una mesa con ese número");
                }
                else
                {
                    _tableRepository.Update(mesa);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
