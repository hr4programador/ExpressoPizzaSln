using System;
using System.Collections.Generic;

namespace ExpressoPizza.Dominio.Entidades
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public List<ItemPedido> ItensPedido { get; set; }
        public decimal ValorTotalPedido { get; set; }

        public Pedido()
        {
            ItensPedido = new List<ItemPedido>();
            DataPedido = DateTime.Now;
        }

        public void AdicionarItemPedido(ItemPedido itemPedido)
        {
            ItensPedido.Add(itemPedido);
        }
    }
}