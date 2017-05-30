using ExpressoPizza.Dominio.Entidades;
using ExpressoPizza.Infra.Data.Repositorio;
using System;
using System.Windows.Forms;

namespace ExpressoPizza.Forms
{
    public partial class FrmSelecionarCliente : Form
    {
        private Cliente clienteSelecionado;
        private ClienteRepositorio clienteRepositorio;

        public ClienteRepositorio ClienteRepositorio
        {
            get { return clienteRepositorio ?? (clienteRepositorio = new ClienteRepositorio()); }
        }

        public FrmSelecionarCliente()
        {
            InitializeComponent();
            GridClientes.AutoGenerateColumns = false;
            ProcurarCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
        }

        public Cliente ObterClienteSelecionado()
        {
            return clienteSelecionado ?? (clienteSelecionado = new Cliente() { Nome = "" });
        }

        private void ProcurarCliente()
        {
            BindingSource source = new BindingSource();
            int numeroTelefone;
            int.TryParse(TxtTelefone.Text, out numeroTelefone);
            source.DataSource = ClienteRepositorio.ObterClientes(numeroTelefone);
            GridClientes.DataSource = source;
        }

        private void BtnProcurarCliente_Click(object sender, EventArgs e)
        {
            ProcurarCliente();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            SelecionarCliente();
        }

        private void GridClientes_DoubleClick(object sender, EventArgs e)
        {
            SelecionarCliente();
        }

        private void SelecionarCliente()
        {
            var rows = GridClientes.SelectedRows;
            foreach (DataGridViewRow row in rows)
                clienteSelecionado = (row.DataBoundItem as Cliente);
            Close();
        }

        private void TxtTelefone_KeyUp(object sender, KeyEventArgs e)
        {
            ProcurarCliente();
        }
    }
}