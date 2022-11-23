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

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Image.FromFile("../image/imgTeste.png");
            img.Image = image;
            DgvProdutos.Columns.Add(img);
            img.HeaderText = "Image";
            img.Name = "img";

            // this.DgvProdutos.Rows.Add(img, "a", "a", "a");
        }
    }
}
