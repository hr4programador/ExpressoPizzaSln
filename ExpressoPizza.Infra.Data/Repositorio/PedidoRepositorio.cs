using ExpressoPizza.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ExpressoPizza.Infra.Data.Repositorio
{
    public class PedidoRepositorio
    {
        private static List<Pedido> Pedidos = new List<Pedido>();

        public void Adicionar(Pedido pedido)
        {
            pedido.PedidoId = ObterMaxId();
            PedidoRepositorio.Pedidos.Add(pedido);
        }

        public Pedido Obter(int clienteId)
        {
            return PedidoRepositorio.Pedidos.FirstOrDefault(i => i.PedidoId == clienteId);
        }

        public List<Pedido> ObterTodos()
        {
            return PedidoRepositorio.Pedidos;
        }

        public List<Pedido> ObterPedidos(DateTime? dataPedido)
        {
            if (!dataPedido.HasValue)
                return ObterTodos();

            return PedidoRepositorio.Pedidos.Where(c => c.DataPedido == dataPedido).ToList();
        }

        public int ObterMaxId()
        {
            return PedidoRepositorio.Pedidos.Count() > 0 ? PedidoRepositorio.Pedidos.Max(p => p.PedidoId) + 1 : 0;
        }
    }
}