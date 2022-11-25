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

            this.DgvProdutos.Rows.Add(1,Properties.Resources.ResourceManager.GetObject("imgTeste"), "a", "a", "Comprar");
        }
    }
}
