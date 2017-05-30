using ExpressoPizza.Dominio;
using ExpressoPizza.Forms;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ExpressoPizza
{
    public partial class Principal : Form
    {
        public static Usuario Usuario { get; set; }

        public static void SetUsuario(Usuario usuario)
        {
            Principal.Usuario = usuario;
        }

        public Principal()
        {
            InitializeComponent();
            Principal.Usuario = new Usuario();
        }

        private void Panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Panel1_MouseHover_1(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Panel1_MouseLeave_1(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.None;
        }

        private void Panel2_MouseHover(object sender, EventArgs e)
        {
            (sender as Panel).BorderStyle = BorderStyle.Fixed3D;
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
            (sender as Panel).BorderStyle = BorderStyle.None;
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Shown(object sender, EventArgs e)
        {
            if (!Usuario.IsUsuarioAutenticado)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                statusStrip.Text = "Olá " + Usuario.Nome;
                statusStrip.Refresh();
            }
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ConfigurarCalendario();
        }

        private void ConfigurarCalendario()
        {
            DateTime dt = DateTime.Now;
            var diaDaSemana = dt.ToString("dddd", new CultureInfo("pt-BR"));
            var primeiraLetra = diaDaSemana.Substring(0, 1);
            var restante = diaDaSemana.Substring(1, lblDiaSemana.Text.Length);
            diaDaSemana = primeiraLetra.ToUpper() + restante;
            lblDiaSemana.Text = diaDaSemana;
            lblDiaMes.Text = dt.Day.ToString();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            FrmPizza frmPizza = new FrmPizza();
            frmPizza.ShowDialog();
        }
    }
}