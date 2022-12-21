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
    public partial class FrmAlterarProduto : Form
    {
        public FrmAlterarProduto()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(frmGerenciarProdutos.idProduto, txtDescricao.Text, Decimal.Parse(txtPreco.Text), txtLink.Text, int.Parse(txtQtde.Text));

            ProdutoDAO ProdutoDAO = new ProdutoDAO();

            ProdutoDAO.Alterar(produto);

            MessageBox.Show("Produto alterado com sucesso!");
        }

        private void btnLocaliza_Click(object sender, EventArgs e)
        {
            if (link.ShowDialog() == DialogResult.OK)
            {
                string filePath = link.FileName;
                txtLink.Text = filePath;
            }
        }

        private void FrmAlterarProduto_Load(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();
            Produto produto = dao.GetProduto(frmGerenciarProdutos.idProduto);
            txtDescricao.Text = produto.Nome;
            txtPreco.Text = produto.Preco.ToString();
            txtLink.Text = produto.Imagem;
            txtQtde.Text = produto.Quantidade.ToString();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
