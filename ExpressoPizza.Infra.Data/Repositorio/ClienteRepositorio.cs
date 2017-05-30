using ExpressoPizza.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ExpressoPizza.Infra.Data.Repositorio
{
    public class ClienteRepositorio
    {
        private static List<Cliente> Clientes = new List<Cliente>();

        public void Adicionar(Cliente cliente)
        {
            cliente.ClienteId = ObterMaxId();
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

        public List<Cliente> ObterClientes(int numeroTelefone)
        {
            if (numeroTelefone == 0)
                return ObterTodos();

            return ClienteRepositorio.Clientes.Where(c => c.Telefone == numeroTelefone).ToList();
        }

        public int ObterMaxId()
        {
            return ClienteRepositorio.Clientes.Count() > 0 ? ClienteRepositorio.Clientes.Max(p => p.ClienteId) + 1 : 0;
        }
    }
}