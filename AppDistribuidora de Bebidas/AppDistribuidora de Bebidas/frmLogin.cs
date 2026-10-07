using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDistribuidora_de_Bebidas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            frmCadastro fc = new frmCadastro();
            fc.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "Flávio";
            string senha = "123";
            frmMenuPrincipal fm = new frmMenuPrincipal();

            if (txtUsuario.Text == usuario && txtSenha.Text == senha)
            {
                this.Visible = false;
                MessageBox.Show("Logado com sucesso!");
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro nome de usuario  ou erro de senha tente de novo");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}