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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void btnLocaliza_Click(object sender, EventArgs e)
        {
            if (link.ShowDialog() == DialogResult.OK) 
            {
                string filePath = link.FileName;
                txtLink.Text = filePath;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(0, txtDescricao.Text, Decimal.Parse(txtPreco.Text), txtLink.Text, int.Parse(txtPreco.Text));

            ProdutoDAO ProdutoDAO = new ProdutoDAO();

            ProdutoDAO.Inserir(produto);

            MessageBox.Show("Produto cadastrado com sucesso!");
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
