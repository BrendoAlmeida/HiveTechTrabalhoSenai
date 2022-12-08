using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveTech
{
    internal class ItensCarrinho : Produto
    {
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }

        public ItensCarrinho(int id, string nome, decimal preco, string imagem, int quantidade, decimal valorTotal) : base(id, nome, preco, imagem)
        {
            Quantidade = quantidade;
            ValorTotal = valorTotal;
        }   
    }
}
