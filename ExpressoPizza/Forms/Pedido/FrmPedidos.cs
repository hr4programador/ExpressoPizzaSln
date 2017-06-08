using ExpressoPizza.Dominio.Entidades;
using ExpressoPizza.Infra.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExpressoPizza.Forms
{
    public enum ModoAcesso
    {
        Cadastro,
        Edicao
    }

    public partial class FrmPedidos : Form
    {
        public ModoAcesso ModoAcesso;
        private PedidoRepositorio pedidoRepositorio;

        public PedidoRepositorio PedidoRepositorio
        {
            get { return pedidoRepositorio ?? (pedidoRepositorio = new PedidoRepositorio()); }
        }

        private List<Pizza> pizzaSelecionadas;

        public List<Pizza> PizzaSelecionadas
        {
            get { return pizzaSelecionadas ?? (pizzaSelecionadas = new List<Pizza>()); }
            set { pizzaSelecionadas = value; }
        }

        private Cliente Cliente { get; set; }

        private Pedido pedido;

        public Pedido Pedido
        {
            get { return pedido ?? (pedido = new Pedido()); }
            set { pedido = value; }
        }

        public FrmPedidos(Pedido pedido)
        {
            InitializeComponent();
            Pedido = pedido;
            ModoAcesso = ModoAcesso.Edicao;
            GridItensPedido.AutoGenerateColumns = false;
            CarregarCampos();
        }

        public FrmPedidos()
        {
            InitializeComponent();
            ModoAcesso = ModoAcesso.Cadastro;
        }

        private void CarregarCampos()
        {
            TxtNumeroPedido.Text = Pedido.PedidoId.ToString();
            TxtNomeCliente.Text = Pedido.Cliente.Nome;

            PizzaSelecionadas = Pedido.ItensPedido.Select(i => i.Pizza).ToList();
            BindingSource source = new BindingSource();
            source.DataSource = PizzaSelecionadas;
            GridItensPedido.DataSource = source;
            cboFormaPagamento.SelectedItem = Pedido.FormaPagamento;
            TxtAnotacoes.Text = Pedido.Anotacoes;
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

            Pedido.DataPedido = DateTime.Now;
            Pedido.Anotacoes = TxtAnotacoes.Text;
            Pedido.FormaPagamento = cboFormaPagamento.SelectedItem.ToString();
            Pedido.Situacao = "Cadastrado";

            Pedido.ItensPedido.Clear();
            foreach (DataGridViewRow item in GridItensPedido.Rows)
            {
                var pizza = (item.DataBoundItem as Pizza);
                Pedido.AdicionarItemPedido(new ItemPedido() { Pizza = pizza });
            }
            if (ModoAcesso == ModoAcesso.Cadastro)
            {
                PedidoRepositorio.Adicionar(Pedido);
                Cliente.AdicionarPedido(Pedido);
            }

            Close();
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(TxtNomeCliente.Text))
                throw new ArgumentException("Informe o nome do cliente");

            if (PizzaSelecionadas.Count == 0)
                throw new ArgumentException("Adicione pelo menos um item");

            if (cboFormaPagamento.SelectedIndex == -1)
                throw new ArgumentException("Informe a forma de pagamento");
        }

        private void GridItensPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == GridItensPedido.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == GridItensPedido.Columns["Deletar"].Index)
            {
                if (MessageBox.Show("Deseja realmente deletar este item ?", "Confirmar...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var pizza = GridItensPedido.Rows[e.RowIndex].DataBoundItem as Pizza;
                    Pedido.RemoverItemPedido(pizza);
                    ProcurarPizza();
                }
            }
        }

        private void GridItensPedido_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == GridItensPedido.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == GridItensPedido.Columns["Deletar"].Index)
            {
                var iconDelete = Properties.Resources.icon4;
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - iconDelete.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - iconDelete.Height) / 2;
                e.Graphics.DrawImage(iconDelete, new System.Drawing.Point(x, y));

                e.Handled = true;
            }
        }
    }
}