using ExpressoPizza.Dominio.Entidades;
using System;
using System.Windows.Forms;

namespace ExpressoPizza.Forms
{
    public partial class FrmPedidos : Form
    {
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
            FrmSelecionarCliente frmSelecinarCliente = new FrmSelecionarCliente();
            frmSelecinarCliente.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmItemPedido frmItemPedido = new FrmItemPedido();
            frmItemPedido.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}