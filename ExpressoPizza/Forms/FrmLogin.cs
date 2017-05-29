using ExpressoPizza.Dominio;
using ExpressoPizza.Infra.Data.Repositorio;
using System;
using System.Windows.Forms;

namespace ExpressoPizza
{
    public partial class FrmLogin : Form
    {
        private UsuarioRepositorio UsuarioRepositorio = new UsuarioRepositorio();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Autenticar();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Enter(object sender, EventArgs e)
        {
            Autenticar();
        }

        public void Autenticar()
        {
            var usuario = UsuarioRepositorio.ObterUsuario(txtUsuario.Text, txtSenha.Text);
            if (usuario.IsUsuarioAutenticado)
            {
                Principal.SetUsuario(usuario);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Autenticar();
            }
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Autenticar();
            }
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }
    }
}