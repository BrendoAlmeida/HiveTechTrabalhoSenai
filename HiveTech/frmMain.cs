using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiveTech
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarrinho frmCarrinho = new FrmCarrinho();
            frmCarrinho.MdiParent = this;
            frmCarrinho.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (LoginInfo.IsAdmin)
            {
                administradorToolStripMenuItem.Visible = true;
            }
            else
            {
                administradorToolStripMenuItem.Visible = false;
            }
        }
    }
}
