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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            frmCadastroDeProdutos fcp = new frmCadastroDeProdutos();
            fcp.ShowDialog();
        }

        private void btnDadosdoProduto_Click(object sender, EventArgs e)
        {
            frmDadosDeProdutos fdp = new frmDadosDeProdutos();
            fdp.ShowDialog();
        }

        private void btnTarefadoProduto_Click(object sender, EventArgs e)
        {
            frmTarefaDoProduto frmTarefaDo = new frmTarefaDoProduto();
            frmTarefaDo.ShowDialog();
        }
    }

}
