using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.CNegocio.Services
{
    class WaiterService
    {
        private readonly MeseroRepository _waiterRepository = new MeseroRepository();
        public async Task<List<Mesero>> ObtenerMeserosActivos()
        {
            return await _waiterRepository.Read(true);
        }
        public async Task<List<Mesero>> ObtenerMeserosEliminados()
        {
            return await _waiterRepository.Read(false);
        }
        public Mesero ObtenerMeseroPorID(int id)
        {
            return _waiterRepository.SearchObject(id);
        }
        public void CambiarEstado(int id)
        {
            _waiterRepository.ChangeState(id);
        }
        public List<Mesero> BuscarPorNombre(string nombre)
        {
            return _waiterRepository.Search(nombre);
        }
        public void CrearMesero(Mesero mesero, List<int> diasDeTrabajo)
        {
            try
            {
                if (ValidarDatos(mesero))
                {
                    _waiterRepository.Create(mesero, diasDeTrabajo);
                }              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ActualizarMesero(Mesero mesero, List<int> diasDeTrabajo)
        {
            try
            {
                if (ValidarDatos(mesero))
                {
                    _waiterRepository.Update(mesero, diasDeTrabajo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ValidarDatos(Mesero mesero)
        {
            if (_waiterRepository.ExistDNI(mesero))
            {
                throw new Exception("Ya existe un mesero con ese dni");
            }
            else if (_waiterRepository.ExistPhone(mesero))
            {
                throw new Exception("Ya existe un mesero con ese teléfono");
            }
            else
            {
                return true;
            }
        }
    }
}
