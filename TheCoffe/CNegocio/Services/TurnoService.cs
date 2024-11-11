using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.CNegocio.Services
{
    class TurnoService
    {
        private readonly TurnoRepository _turnoRepository = new TurnoRepository();
        private readonly PedidoRepository _orderRepository = new PedidoRepository();
        public async Task<List<Turno_Caja>> ObtenerTurno()
        {
            return await _turnoRepository.Read();
        }
        public async Task<List<Venta>> ObtenerVentasDeUnTurno(int id_turno)
        {
            return await _orderRepository.ObtenerVentasDeTurno(id_turno);
        }
        public bool HayTurnos()
        {
            return _turnoRepository.HayTurnos();
        }
        public Turno_Caja ObtenerTurnoPorID(int id)
        {
            return _turnoRepository.SearchObject(id);
        }
        public List<Turno_Caja> BuscarPorNombreDeUsuario(string nombre)
        {
            return _turnoRepository.Search(nombre);
        }
        public Turno_Caja ObtenerUltimoTurno()

        {
            return  _turnoRepository.ObtenerUltimoTurno();
        }
        public void CrearTurno(Turno_Caja turno)
        {
            try
            {
                _turnoRepository.Create(turno);
                Turno.TurnoActual = turno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ActualizarTurno(Turno_Caja turno)
        {
            try
            {
                _turnoRepository.Update(turno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Turno_Caja>> FiltrarPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            return await _turnoRepository.FiltrarPorFecha(fechaDesde, fechaHasta);
        }
    }
}
