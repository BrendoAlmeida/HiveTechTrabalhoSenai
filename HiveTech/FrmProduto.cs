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

            MessageBox.Show(Convert.ToString(ListProduto));

            this.DgvProdutos.Rows.Add(1,Properties.Resources.ResourceManager.GetObject("imgTeste"), "a", "a", "Comprar"); 
        }

        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow teste = DgvProdutos.Rows[DgvProdutos.SelectedCells[0].RowIndex];

            MessageBox.Show(Convert.ToString(teste.Cells["id"].Value));
        }
    }
}
