using ExpressoPizza.Dominio.Entidades;
using ExpressoPizza.Infra.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExpressoPizza.Forms
{
    public partial class FrmPedidos : Form
    {
        private PedidoRepositorio pedidoRepositorio;

        public PedidoRepositorio PedidoRepositorio
        {
            get { return pedidoRepositorio ?? (pedidoRepositorio = new PedidoRepositorio()); }
        }

        private List<Pizza> pizzaSelecionadas;

        public List<Pizza> PizzaSelecionadas
        {
            get { return pizzaSelecionadas ?? (pizzaSelecionadas = new List<Pizza>()); }
        }

        private Cliente Cliente { get; set; }

        private Pedido pedido;

        public Pedido Pedido
        {
            get { return pedido ?? (pedido = new Pedido()); }
        }

        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void BtnProcurarCliente_Click(object sender, EventArgs e)
        {
            ProcurarCliente();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ProcurarPizza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProcurarCliente()
        {
            FrmSelecionarCliente frmSelecinarCliente = new FrmSelecionarCliente();
            frmSelecinarCliente.ShowDialog();
            Cliente = frmSelecinarCliente.ObterClienteSelecionado();
            TxtNomeCliente.Text = Cliente.Nome;
        }

        private void ProcurarPizza()
        {
            FrmItemPedido frmItemPedido = new FrmItemPedido();
            frmItemPedido.ShowDialog();
            BindingSource source = new BindingSource();
            PizzaSelecionadas.AddRange(frmItemPedido.ObterPizzasSelecionadas());
            source.DataSource = PizzaSelecionadas;
            GridItensPedido.DataSource = source;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarPedido();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SalvarPedido()
        {
            Validar();
            var pedido = new Pedido()
            {
                DataPedido = DateTime.Now,
                Cliente = this.Cliente,
                Anotacoes = TxtAnotacoes.Text
            };

            foreach (DataGridViewRow item in GridItensPedido.Rows)
            {
                var pizza = (item.DataBoundItem as Pizza);
                pedido.AdicionarItemPedido(new ItemPedido() { Pizza = pizza });
            }
            PedidoRepositorio.Adicionar(pedido);
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(TxtNomeCliente.Text))
                throw new ArgumentException("Informe o nome do cliente");

            if (PizzaSelecionadas.Count == 0)
                throw new ArgumentException("Adicione pelo menos um item");
        }
    }
}