using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.CNegocio.Services
{
    class CustomerService
    {
        private readonly ClienteRepository _customerRepository = new ClienteRepository();
        public List<Cliente> ObtenerClientes()
        {
            return _customerRepository.Read();
        }
        public void CrearCliente(Cliente cliente)
        {
            if (ValidarDatos(cliente))
            {
                try
                {
                    _customerRepository.Create(cliente);                 
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public bool ValidarDatos(Cliente cliente)
        {
            if (_customerRepository.ExistCUIT(cliente))
            {
                throw new Exception("Ya existe un cliente con ese cuit");
            }
            else if (_customerRepository.ExistEmail(cliente))
            {
                throw new Exception("Ya existe un cliente con ese email");
            }
            else
            {
                return true;
            }
        }
    }
}
