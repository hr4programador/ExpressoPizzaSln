using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressoPizza.Dominio.Entidades
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public List<ItemPedido> ItensPedido { get; set; }
        public Cliente Cliente { get; set; }
        public string FormaPagamento { get; set; }
        public string Situacao { get; set; }
        public string Anotacoes { get; set; }

        public string EnderecoCliente
        {
            get { return Cliente.Endereco; }
        }

        public int NumeroTelefoneCliente
        {
            get { return Cliente.Telefone; }
        }

        public Pedido()
        {
            ItensPedido = new List<ItemPedido>();
            DataPedido = DateTime.Now;
        }

        public void AdicionarItemPedido(ItemPedido itemPedido)
        {
            ItensPedido.Add(itemPedido);
        }

        public void RemoverItemPedido(Pizza pizza)
        {
            ItensPedido.RemoveAll(i => i.Pizza.PizzaId == pizza.PizzaId);
        }

        public decimal ObterValorTotal()
        {
            return ItensPedido.Sum(i => i.Pizza.Preco);
        }
    }
}