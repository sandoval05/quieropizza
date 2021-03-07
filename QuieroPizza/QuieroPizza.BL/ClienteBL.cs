using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ClienteBL
    {
        Contexto _contexto;

        public List<Cliente> ListadeClientes { get; set; }


        public ClienteBL()
        {
            _contexto = new Contexto();
            ListadeClientes = new List<Cliente>();
        }


        public List<Cliente> ObtenerClientes()
        {

            ListadeClientes = _contexto.Clientes.ToList();
            return ListadeClientes;
        }

        public void GuardarCliente(Cliente cliente)
        {

            if (cliente.id == 0)
            {
                _contexto.Clientes.Add(cliente);
            }
            else
            {
                var clienteExistente = _contexto.Clientes.Find(cliente.id);
                clienteExistente.nombre = cliente.nombre;
                clienteExistente.numero = cliente.numero;
                clienteExistente.direccion = cliente.direccion;
               
            }

            _contexto.SaveChanges();
        }

        public Cliente ObtenerCliente(int id)
        {
            var cliente = _contexto.Clientes.Find(id);
            return cliente;
        }

        public void EliminarCliente(int id)
        {
            var cliente = _contexto.Clientes.Find(id);

            _contexto.Clientes.Remove(cliente);
            _contexto.SaveChanges();
        }

    }
}