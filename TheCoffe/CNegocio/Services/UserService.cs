using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.CNegocio.Services
{
    class UserService
    {
        private readonly UsuarioRepository _userRepository = new UsuarioRepository();
        public async Task<List<Usuario>> ObtenerUsuariosActivos()
        {
            return await _userRepository.Read(true);
        }
        public async Task<List<Usuario>> ObtenerUsuariosEliminados()
        {
            return await _userRepository.Read(false);
        }
        public Usuario ObtenerUsuarioPorID(int id)
        {
            return _userRepository.SearchObject(id);
        }
        public void CambiarEstado(int id)
        {
            _userRepository.ChangeState(id);
        }
        public List<Usuario> BuscarPorNombre(string nombre)
        {
            return _userRepository.Search(nombre);
        }
        public async Task<List<rol_usuario>> ObtenerRoles()
        {
            return await _userRepository.listRoles();
        }
        public void CrearUsuario(Usuario usuario)
        {
            try
            {
                if (ValidarDatos(usuario))
                {
                    _userRepository.Create(usuario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ActualizarUsuario(Usuario usuario)
        {
            try
            {
                if (ValidarDatos(usuario))
                {
                    _userRepository.Update(usuario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ValidarDatos(Usuario usuario)
        {
            if (_userRepository.ExistUser(usuario))
            {
                throw new Exception("Este usuario ya esta ocupado");
            }
            else if (_userRepository.ExistPhone(usuario))
            {
                throw new Exception("Ya existe un usuario con ese teléfono");
            }
            else
            {
                return true;
            }
        }
    }
}
