using ExpressoPizza.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace ExpressoPizza.Infra.Data.Repositorio
{
    public class ClienteRepositorio
    {
        private static List<Cliente> Clientes = new List<Cliente>();

        public void Adicionar(Cliente cliente)
        {
            ClienteRepositorio.Clientes.Add(cliente);
        }

        public Cliente Obter(int clienteId)
        {
            return ClienteRepositorio.Clientes.FirstOrDefault(i => i.ClienteId == clienteId);
        }

        public List<Cliente> ObterTodos()
        {
            return ClienteRepositorio.Clientes;
        }
    }
}