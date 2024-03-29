﻿using MySql.Data.MySqlClient;
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

        public static void Comprar(string UserId)
        {
            MySqlCommand comando = new MySqlCommand();

            ServerInfo Server = new ServerInfo();
            Server.StartServer();

            comando.Connection = Server.conexao;
            comando.CommandText = "INSERT INTO pedidos (id_cliente, date_time_pedido) VALUES (@id_cliente, '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            comando.Parameters.AddWithValue("@id_cliente", UserId);
            comando.ExecuteNonQuery();

            string idPedido = comando.LastInsertedId.ToString();

            foreach (ItensCarrinho item in Produtos)
            {
                comando.CommandText = "INSERT INTO itenspedidos (id_pedido, id_produto, produto, quantidade, sub_total) VALUES (@id_pedido, @id_produto, @nomeProduto, @quantidade, @sub_total)";
                comando.Parameters.AddWithValue("@id_pedido", idPedido);
                comando.Parameters.AddWithValue("@id_produto", item.Id);
                comando.Parameters.AddWithValue("@nomeProduto", item.Nome);
                comando.Parameters.AddWithValue("@quantidade", item.Quantidade);
                comando.Parameters.AddWithValue("@sub_total", item.ValorTotal);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                comando.CommandText = "SELECT quantidade FROM produto WHERE id = @id_produto";
                comando.Parameters.AddWithValue("@id_produto", item.Id);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                int quantidade = int.Parse(reader["quantidade"].ToString());
                reader.Close();

                if (quantidade < item.Quantidade)
                {
                    return;
                }

                comando.Parameters.Clear();

                quantidade -= item.Quantidade;
                comando.CommandText = "UPDATE produto SET quantidade = @quantidade WHERE id = @id_produto";
                comando.Parameters.AddWithValue("@quantidade", quantidade);
                comando.Parameters.AddWithValue("@id_produto", item.Id);

                comando.ExecuteNonQuery();

                comando.Parameters.Clear();
            }
            comando.Connection.Close();
        }

        public static int GetId(int index)
        {
            return Produtos[index].Id;
        }
    }
}
