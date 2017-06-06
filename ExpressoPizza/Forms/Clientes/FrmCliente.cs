using ExpressoPizza.Dominio.Entidades;
using ExpressoPizza.Infra.Data.Repositorio;
using System;
using System.Windows.Forms;

namespace ExpressoPizza.Forms
{
    public partial class FrmCliente : Form
    {
        #region "Propriedades"
        private ClienteRepositorio clienteRepositorio;

        public ClienteRepositorio ClienteRepositorio
        {
            get { return clienteRepositorio ?? (clienteRepositorio = new ClienteRepositorio()); }
        }

        # endregion

        #region "Eventos"

        public FrmCliente()
        {
            InitializeComponent();
            GridClientes.AutoGenerateColumns = false;
            ProcurarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            SalvarCliente();
        }

        #endregion "Eventos"

        #region "Métodos"

        private void Validar()
        {
            if (string.IsNullOrEmpty(TxtNome.Text))
                throw new ArgumentException("Informe o nome");

            if (string.IsNullOrEmpty(TxtTelefone.Text))
                throw new ArgumentException("Informe o telefone");

            if (string.IsNullOrEmpty(TxtEndereco.Text))
                throw new ArgumentException("Informe o endereço do cliente");
        }

        private void SalvarCliente()
        {
            try
            {
                Validar();

                var cliente = new Cliente()
                {
                    Nome = TxtNome.Text,
                    Telefone = int.Parse(TxtTelefone.Text),
                    Endereco = TxtEndereco.Text
                };

                ClienteRepositorio.Adicionar(cliente);
                ProcurarClientes();
                LimparCampos();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch
            {
                MessageBox.Show("Os dados informados são inválidos");
            }
        }

        private void ProcurarClientes()
        {
            BindingSource source = new BindingSource();
            source.DataSource = ClienteRepositorio.ObterTodos();
            GridClientes.DataSource = source;
        }

        private void LimparCampos()
        {
            TxtNome.Clear();
            TxtTelefone.Clear();
            TxtEndereco.Clear();
            TxtNome.Focus();
        }

        #endregion "Métodos"

        private void TxtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                SalvarCliente();
            }
        }

        private void TxtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                SalvarCliente();
            }
        }
    }
}