using System.Collections.Generic;

namespace ExpressoPizza.Dominio.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public string Endereco { get; set; }

        public Cliente()
        {
            Pedidos = new List<Pedido>();
        }

        public void AdicionarPedido(Pedido pedido)
        {
            pedido.Cliente = this;
            Pedidos.Add(pedido);
        }
    }
}