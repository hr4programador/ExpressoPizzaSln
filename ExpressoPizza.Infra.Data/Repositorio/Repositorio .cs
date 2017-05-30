using ExpressoPizza.Dominio.Entidades;
using System.Collections.Generic;

namespace ExpressoPizza.Infra.Data.Repositorio
{
    public interface IRepositorio
    {
        void Adicionar(Cliente cliente);

        Cliente Obter(int clienteId);

        List<Cliente> ObterTodos();

        List<Cliente> ObterClientes(string nome);
    }
}