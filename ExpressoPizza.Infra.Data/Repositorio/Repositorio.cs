using ExpressoPizza.Dominio.Entidades;
using System;

namespace ExpressoPizza.Infra.Data.Repositorio
{
    public class Repositorio
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private PizzaRepositorio pizzaRepositorio = new PizzaRepositorio();
        private PedidoRepositorio pedidoRepositorio = new PedidoRepositorio();

        public void CargaInicial()
        {
            //Adicionar Pizzas
            var pizza1 = new Pizza() { PizzaId = 1, Nome = "Calabresa", Preco = 35.50m };
            pizzaRepositorio.Adicionar(pizza1);

            var pizza2 = new Pizza() { PizzaId = 2, Nome = "Mussarela", Preco = 45.50m };
            pizzaRepositorio.Adicionar(pizza2);

            //Adicionar Cliente1
            var cliente1 = new Cliente() { ClienteId = 1, Nome = "Leo", Endereco = "Sacadura cabral", Telefone = 38603904 };

            //Adicionar pedido1
            var pedido1 = new Pedido() { PedidoId = 1, Anotacoes = " troco para 50", DataPedido = DateTime.Now, FormaPagamento = "Dinheiro" };
            pedido1.AdicionarItemPedido(new ItemPedido() { ItemPedidoId = 1, Pizza = pizza1 });
            cliente1.AdicionarPedido(pedido1);

            clienteRepositorio.Adicionar(cliente1);
            pedidoRepositorio.Adicionar(pedido1);

            //Adicionar Cliente2
            var cliente2 = new Cliente() { ClienteId = 2, Nome = "Gabriel", Endereco = "Antonio Henrique", Telefone = 89745635 };
            clienteRepositorio.Adicionar(cliente2);
        }
    }
}