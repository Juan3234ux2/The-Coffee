using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.CNegocio.Services
{
    class AuthService
    {
        private readonly UsuarioRepository _userRepository = new UsuarioRepository();
        public Usuario Login(string nombreUsuario, string contraseña)
        {
            var usuario = _userRepository.SearchByUsername(nombreUsuario);
            if (usuario == null)
            {
                throw new Exception("No existe el usuario");
            }
            else
            {
                if(usuario.contraseña == contraseña)
                {
                    return usuario;
                }
                else
                {
                    throw new Exception("Contraseña incorrecta");
                }
            }
        }
    }
}
