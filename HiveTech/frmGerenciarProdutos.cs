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
    public partial class frmGerenciarProdutos : Form
    {
        List<Produto> produtos;
        ProdutoDAO dao = new ProdutoDAO();
        public static int idProduto;

        private void CarregarProdutos()
        {
            produtos = dao.Listar();

            foreach (Produto produto in produtos)
            {
                string Image = produto.Imagem;
                this.DgvProdutos.Rows.Add(produto.Id, Properties.Resources.ResourceManager.GetObject(Image.Replace("img/", "").Replace(".png", "")), produto.Nome, "R$" + produto.Preco, produto.Quantidade, "Alterar");
            }
        }

        public frmGerenciarProdutos()
        {
            InitializeComponent();
        }

        private void frmGerenciarProdutos_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void AtualizarCarrinho()
        {
            DgvProdutos.Rows.Clear();
            CarregarProdutos();
        }

        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = DgvProdutos.CurrentRow.Cells[0].Value.ToString();
            idProduto = int.Parse(id);
            if (e.ColumnIndex == 5)
            {
                FrmAlterarProduto alterarProduto = new FrmAlterarProduto();
                alterarProduto.ShowDialog();
                AtualizarCarrinho();
            }
            else if (e.ColumnIndex == 6)
            {
                dao.Apagar(idProduto);
                AtualizarCarrinho();
            }

            AtualizarCarrinho();
        }
    }
}
