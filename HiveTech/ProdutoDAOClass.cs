using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    public class ProdutoDAO
    {
        public MySqlConnection conexao { get; set; }

        public ProdutoDAO()
        {
            conexao = new MySqlConnection("Server=localhost;Database=HiveTechDB;Uid=root;Pwd=;");
            conexao.Open();
        }

        public void Inserir(Produto produto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO produto (nome, preco, quantidade, imagem) VALUES (@NOME, @PRECO, @QUANTIDADE, @IMAGEM)";
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@PRECO", produto.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);
            comando.Parameters.AddWithValue("@IMAGEM", produto.Imagem);
            comando.ExecuteNonQuery();
        }

        public List<Produto> Listar()
        {
            List<Produto> produtos = new List<Produto>();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM produto";

            conexao.Open();

            MySqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                Produto produto = new Produto();
                produto.Id = Convert.ToInt32(reader["id"]);
                produto.Nome = reader["nome"].ToString();
                produto.Preco = Convert.ToDecimal(reader["preco"]);
                produto.Quantidade = Convert.ToInt32(reader["quantidade"]);
                produto.Imagem = reader["imagem"].ToString();
                produtos.Add(produto);
            }
            return produtos;
        }

        public void Alterar(Produto produto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE produto SET nome = @NOME, preco = @PRECO, quantidade = @QUANTIDADE, imagem = @IMAGEM WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@PRECO", produto.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);
            comando.Parameters.AddWithValue("@IMAGEM", produto.Imagem);
            comando.Parameters.AddWithValue("@ID", produto.Id);
            comando.ExecuteNonQuery();
        }

        public void Apagar(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "DELETE FROM produto WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
        }
    }
}

