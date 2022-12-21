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

        public void verifIdAdmin()
        {
            administradorToolStripMenuItem.Visible = LoginInfo.IsAdmin;
            administradorToolStripMenuItem.Enabled = LoginInfo.IsAdmin;
        }

        private void cadastroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto FormProduto = new FormProduto();
            FormProduto.MdiParent = this;
            FormProduto.Show();
        }

        private void gerenciarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerenciarProdutos frmGerenciarProdutos = new frmGerenciarProdutos();
            frmGerenciarProdutos.MdiParent = this;
            frmGerenciarProdutos.Show();
        }

        public void verifIsLogin()
        {
            contaToolStripMenuItem.Visible = LoginInfo.IsLogin;
            contaToolStripMenuItem.Enabled = LoginInfo.IsLogin;

            loginToolStripMenuItem.Visible = !LoginInfo.IsLogin;
            loginToolStripMenuItem.Enabled = !LoginInfo.IsLogin;

            pedidosToolStripMenuItem.Visible = LoginInfo.IsLogin;
            pedidosToolStripMenuItem.Enabled = LoginInfo.IsLogin;

            lblUser.Text = LoginInfo.Nome;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginInfo.IsLogin = false;
            LoginInfo.IsAdmin = false;
            LoginInfo.ChaveCinfirmado = false;
            verifIsLogin();
            verifIdAdmin();
            liberarAdmin();
        }

        private void alterarInformaçõesDeCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlterarCadastro frmAlterarCliente = new FrmAlterarCadastro();
            frmAlterarCliente.MdiParent = this;
            frmAlterarCliente.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos frmPedidos = new Pedidos();
            frmPedidos.MdiParent = this;
            frmPedidos.Show();
        }

        private void atualizarHora_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void criarAdiministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerenciarClientes Adm = new FrmGerenciarClientes();
            Adm.MdiParent = this;
            Adm.Show();
        }

        public void liberarAdmin()
        {
            cadastroProdutosToolStripMenuItem.Enabled = LoginInfo.ChaveCinfirmado;
            cadastroProdutosToolStripMenuItem.Visible = LoginInfo.ChaveCinfirmado;

            gerenciarEstoqueToolStripMenuItem.Enabled = LoginInfo.ChaveCinfirmado;
            gerenciarEstoqueToolStripMenuItem.Visible = LoginInfo.ChaveCinfirmado;

            criarAdministradorToolStripMenuItem.Enabled = LoginInfo.ChaveCinfirmado;
            criarAdministradorToolStripMenuItem.Visible = LoginInfo.ChaveCinfirmado;
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginInfo.ChaveCinfirmado)
            {
                return;
            }
            FrmVerifChaveAdmin Chave = new FrmVerifChaveAdmin();
            Chave.MdiParent = this;
            Chave.Show();
        }
    }
}
