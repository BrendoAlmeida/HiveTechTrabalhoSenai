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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            List<ItensCarrinho> pedidos = pedidoDAO.ListarPedidos(1);
            foreach (ItensCarrinho pedido in pedidos)
            {
                string Image = pedido.Imagem;

                this.DgvProdutos.Rows.Add(pedido.Id, Properties.Resources.ResourceManager.GetObject(Image.Replace("img/", "").Replace(".png", "")), pedido.Nome, "R$" + pedido.Preco, pedido.Quantidade, "R$" + pedido.ValorTotal);
            }
        }
    }
}
