using ExpressoPizza.Dominio.Entidades;
using ExpressoPizza.Infra.Data.Repositorio;
using System;
using System.Windows.Forms;

namespace ExpressoPizza.Forms
{
    public partial class FrmPizza : Form
    {
        private PizzaRepositorio pizzaRepositorio;

        public PizzaRepositorio PizzaRepositorio
        {
            get { return pizzaRepositorio ?? (pizzaRepositorio = new PizzaRepositorio()); }
        }

        public FrmPizza()
        {
            InitializeComponent();
            GridPizza.AutoGenerateColumns = false;
            ProcurarPizza();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            SalvarPizza();
        }

        private void SalvarPizza()
        {
            try
            {
                Validar();
                var pizza = new Pizza()
                {
                    Nome = TxtNome.Text,
                    Preco = decimal.Parse(TxtPreco.Text)
                };

                PizzaRepositorio.Adicionar(pizza);
                ProcurarPizza();
                LimparCampos();
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

        private void ProcurarPizza()
        {
            BindingSource source = new BindingSource();
            source.DataSource = PizzaRepositorio.ObterTodos();
            GridPizza.DataSource = source;
        }

        private void LimparCampos()
        {
            TxtNome.Clear();
            TxtPreco.Clear();
            TxtNome.Focus();
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(TxtNome.Text))
                throw new ArgumentException("Informe o nome da pizza");
            if (string.IsNullOrEmpty(TxtPreco.Text))
                throw new ArgumentException("Informe o preço da pizza");
        }

        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }

            if ((Keys)e.KeyChar == Keys.Enter)
            {
                SalvarPizza();
            }
        }
    }
}