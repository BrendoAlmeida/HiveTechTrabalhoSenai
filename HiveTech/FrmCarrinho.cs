﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiveTech
{
    public partial class FrmCarrinho : Form
    {
        public FrmCarrinho()
        {
            InitializeComponent();
        }

        private void FrmCarrinho_Load(object sender, EventArgs e)
        {
            CarregarCarrinho();
        }

        private void CarregarCarrinho()
        {

            if (Carrinho.GetQuantidade() == 0)
            {
                ProdutoDAO Debug = new ProdutoDAO();
                Debug.AdicionarCarrinho(6);

                //MessageBox.Show("Carrinho vazio!");
                //return;
            }

            foreach (ItensCarrinho item in Carrinho.GetProdutos())
            {
                string Image = item.Imagem;
                this.DgvProdutos.Rows.Add(item.Id, Properties.Resources.ResourceManager.GetObject(Image.Replace("img/", "").Replace(".png", "")), item.Nome, "R$" + item.Preco, item.Quantidade, "R$" + item.ValorTotal, "+", "-", "Remover");
            }
        }

        private void AtualizarCarrinho()
        {
            DgvProdutos.Rows.Clear();
            CarregarCarrinho();
        }
        
        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                Carrinho.AdicionarQuantidade(Carrinho.GetId(e.RowIndex));
            }
            else if (e.ColumnIndex == 7)
            {
                Carrinho.SubtrairQuantidade(e.RowIndex);
            }
            else if (e.ColumnIndex == 8)
            {
                Carrinho.Remover(e.RowIndex);
            }

            AtualizarCarrinho();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarCarrinho();
        }
    }
}
