using ExpressoPizza.Dominio.Entidades;
using ExpressoPizza.Infra.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExpressoPizza.Forms
{
    public partial class FrmItemPedido : Form
    {
        private List<Pizza> PizzasSelecionadas = new List<Pizza>();

        private PizzaRepositorio pizzaRepositorio;

        public PizzaRepositorio PizzaRepositorio
        {
            get { return pizzaRepositorio ?? (pizzaRepositorio = new PizzaRepositorio()); }
        }

        public FrmItemPedido()
        {
            InitializeComponent();
            GridPizza.AutoGenerateColumns = false;
            ProcurarPizza();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridPizza.SelectedRows)
                PizzasSelecionadas.Add((row.DataBoundItem as Pizza));
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnProcurarCliente_Click(object sender, EventArgs e)
        {
            ProcurarPizza();
        }

        private void ProcurarPizza()
        {
            BindingSource source = new BindingSource();
            source.DataSource = PizzaRepositorio.ObterPizzas(TxtNome.Text);
            GridPizza.DataSource = source;
        }

        private void TxtNome_MouseDown(object sender, MouseEventArgs e)
        {
            ProcurarPizza();
        }

        public List<Pizza> ObterPizzasSelecionadas()
        {
            return PizzasSelecionadas;
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
                ProcurarPizza();
        }
    }
}