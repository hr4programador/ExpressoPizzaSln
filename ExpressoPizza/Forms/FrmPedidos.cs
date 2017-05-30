using ExpressoPizza.Dominio.Entidades;
using System;
using System.Windows.Forms;

namespace ExpressoPizza.Forms
{
    public partial class FrmPedidos : Form
    {
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
            source.DataSource = frmItemPedido.ObterPizzasSelecionadas();
            GridItensPedido.DataSource = source;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}