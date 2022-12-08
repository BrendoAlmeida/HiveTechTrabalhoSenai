using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveTech
{
    internal static class Carrinho
    {
        private static List<ItensCarrinho> Produtos { get; set; }

        public static void Adicionar(ItensCarrinho produto)
        {
            if (Produtos == null)
            {
                Produtos = new List<ItensCarrinho>();
            }
            Produtos.Add(produto);
        }

        public static void Remover(int id)
        {
            Produtos.RemoveAt(id);
        }

        public static void AdicionarQuantidade(int id)
        {
            int index = Produtos.FindIndex(x => x.Id == id);

            if (index == -1)
            {
                return;
            }

            Produtos[index].Quantidade++;
            CalcularSubTotal(index);
        }

        public static void SubtrairQuantidade(int id)
        {
            if (Produtos[id].Quantidade > 1)
            {
                Produtos[id].Quantidade--;
                CalcularSubTotal(id);
            }
        }

        public static void CalcularSubTotal(int id)
        {
            Produtos[id].ValorTotal = Produtos[id].Preco * Produtos[id].Quantidade;
        }

        public static void Limpar()
        {
            if (Produtos == null)
            {
                return;
            }
            Produtos.Clear();
        }

        public static int GetQuantidade()
        {
            if (Produtos == null)
            {
                Produtos = new List<ItensCarrinho>();
            }
            return Produtos.Count();
        }

        public static bool VerifcarSeExiste(int id)
        {
            if (Produtos == null)
            {
                Produtos = new List<ItensCarrinho>();
            }
            return Produtos.Any(x => x.Id == id);
        }
        
        public static List<ItensCarrinho> GetProdutos()
        {
            if (Produtos == null)
            {
                Produtos = new List<ItensCarrinho>();
            }
            return Produtos;
        }
    
        public static int GetId(int index)
        {
            return Produtos[index].Id;
        }
    }
}
