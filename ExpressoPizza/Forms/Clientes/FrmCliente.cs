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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Validar();
            SalvarCliente();
        }

        #endregion "Eventos"

        #region "Métodos"

        private void Validar()
        {
            if (string.IsNullOrEmpty(TxtNome.Text))
                MessageBox.Show("Informe o nome do cliente");

            if (string.IsNullOrEmpty(TxtTelefone.Text))
                MessageBox.Show("Informe o telefone do cliente");
        }

        private void SalvarCliente()
        {
            var cliente = new Cliente()
            {
                Nome = TxtNome.Text,
                Telefone = int.Parse(TxtTelefone.Text)
            };

            ClienteRepositorio.Adicionar(cliente);
            GridClientes.DataSource = ClienteRepositorio.ObterTodos();
        }

        #endregion "Métodos"
    }
}