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
            comando.CommandText = @"INSERT INTO produto (nome, preco, imagem) VALUES (@NOME, @PRECO, @IMAGEM)";
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@PRECO", produto.Preco);
            comando.Parameters.AddWithValue("@IMAGEM", produto.Imagem);
            comando.ExecuteNonQuery();
        }

        public List<Produto> Listar()
        {
            List<Produto> produtos = new List<Produto>();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM produto";

            MySqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                Produto produto = new Produto(Convert.ToInt32(reader["id"]), reader["nome"].ToString(), Convert.ToDecimal(reader["preco"]), reader["imagem"].ToString());
                produtos.Add(produto);
            }
            reader.Close();
            return produtos;
        }

        public void Alterar(Produto produto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE produto SET nome = @NOME, preco = @PRECO, quantidade = @QUANTIDADE, imagem = @IMAGEM WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@PRECO", produto.Preco);
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

        public void AdicionarCarrinho(int IdProduto)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM produto Where id = @id";
            comando.Parameters.AddWithValue("@id", IdProduto);

            MySqlDataReader reader = comando.ExecuteReader();

            reader.Read();

            ItensCarrinho produto = new ItensCarrinho(Convert.ToInt32(reader["id"]), reader["nome"].ToString(), Convert.ToDecimal(reader["preco"]), reader["imagem"].ToString(), 1, Convert.ToDecimal(reader["preco"]));
            
            reader.Close();

            int id = produto.getId();
            
            if (Carrinho.VerifcarSeExiste(id))
            {
                Carrinho.AdicionarQuantidade(id);
            }
            else
            {
                Carrinho.Adicionar(produto);
            }
        }
    }
}

