using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressoPizza.Dominio.Entidades
{
    public enum FormaPagamento
    {
        Cartao,
        Dinheiro
    }

    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public List<ItemPedido> ItensPedido { get; set; }
        public Cliente Cliente { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public string Anotacoes { get; set; }

        public Pedido()
        {
            ItensPedido = new List<ItemPedido>();
            DataPedido = DateTime.Now;
        }

        public void AdicionarItemPedido(ItemPedido itemPedido)
        {
            ItensPedido.Add(itemPedido);
        }

        public decimal ObterValorTotal()
        {
            return ItensPedido.Sum(i => i.Pizza.Preco);
        }
    }
}