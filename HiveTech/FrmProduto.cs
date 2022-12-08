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
    public partial class FrmProduto : Form
    {
        ProdutoDAO ProdDao = new ProdutoDAO();

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            List<Produto> ListProduto = ProdDao.Listar();

            foreach(Produto produto in ListProduto)
            {
                string Image = produto.Imagem;

                this.DgvProdutos.Rows.Add(produto.Id, Properties.Resources.ResourceManager.GetObject(Image.Replace("img/", "").Replace(".png", "")), produto.Nome, "R$" + produto.Preco, "Comprar"); 
            }
        }


        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdProduto = (int)DgvProdutos.Rows[DgvProdutos.SelectedCells[0].RowIndex].Cells[0].Value;
            LoginInfo.id = "1";
            if (MessageBox.Show("Deseja confirmar a compra?", "Aviso!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProdDao.AdicionarCarrinho(IdProduto);
            }

            MessageBox.Show("Produto adicionado ao carrinho!");
        }
    }
}
