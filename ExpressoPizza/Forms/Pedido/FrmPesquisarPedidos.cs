using ExpressoPizza.Dominio.Entidades;
using ExpressoPizza.Infra.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExpressoPizza.Forms
{
    public partial class FrmPesquisarPedidos : Form
    {
        private ClienteRepositorio clienteRepositorio;

        public ClienteRepositorio ClienteRepositorio
        {
            get { return clienteRepositorio ?? (clienteRepositorio = new ClienteRepositorio()); }
        }

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

        public FrmPesquisarPedidos()
        {
            InitializeComponent();
            GridItensPedido.AutoGenerateColumns = false;
            ProcurarCliente();
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
            int numeroTelefone;
            int.TryParse(TxtTelefoneCliente.Text, out numeroTelefone);
            var source = new BindingSource();
            source.DataSource = ClienteRepositorio.ObterTodosPedidos(numeroTelefone);
            GridItensPedido.DataSource = source;
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
            Close();
        }

        private void SalvarPedido()
        {
            Validar();
            var pedido = new Pedido()
            {
                DataPedido = DateTime.Now,
                Cliente = this.Cliente
            };
            PedidoRepositorio.Adicionar(pedido);
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(TxtTelefoneCliente.Text))
                throw new ArgumentException("Informe o nome do cliente");

            if (PizzaSelecionadas.Count == 0)
                throw new ArgumentException("Adicione pelo menos um item");
        }

        private void BtnAdicionarPedido_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.ShowDialog();
            ProcurarCliente();
        }

        private void TxtTelefoneCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
                ProcurarCliente();
        }

        private void GridItensPedido_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == GridItensPedido.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == GridItensPedido.Columns["View"].Index)
            {
                var iconDelete = Properties.Resources.view5;
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - iconDelete.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - iconDelete.Height) / 2;
                e.Graphics.DrawImage(iconDelete, new System.Drawing.Point(x, y));

                e.Handled = true;
            }

            if (e.ColumnIndex == GridItensPedido.Columns["Edit"].Index)
            {
                //var iconDelete = Properties.Resources.view5;
                //e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                //var x = e.CellBounds.Left + (e.CellBounds.Width - iconDelete.Width) / 2;
                //var y = e.CellBounds.Top + (e.CellBounds.Height - iconDelete.Height) / 2;
                //e.Graphics.DrawImage(iconDelete, new System.Drawing.Point(x, y));

                //e.Handled = true;
            }
        }
    }
}