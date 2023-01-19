using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    public class Venda
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
    }

    public class VendaDAO : ServerInfo
    {
        public VendaDAO()
        {
            base.StartServer();
        }

        public void Inserir(Venda venda)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO venda (id_cliente, id_produto, quantidade, total) VALUES (@ID_CLIENTE, @ID_PRODUTO, @QUANTIDADE, @TOTAL)";
            comando.Parameters.AddWithValue("@ID_CLIENTE", venda.IdCliente);
            comando.Parameters.AddWithValue("@ID_PRODUTO", venda.IdProduto);
            comando.Parameters.AddWithValue("@QUANTIDADE", venda.Quantidade);
            comando.Parameters.AddWithValue("@TOTAL", venda.Total);
            comando.ExecuteNonQuery();
        }

        public List<Venda> Listar()
        {
            List<Venda> vendas = new List<Venda>();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM venda";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            foreach (DataRow linha in tabela.Rows)
            {
                Venda venda = new Venda();
                venda.Id = Convert.ToInt32(linha["id"]);
                venda.IdCliente = Convert.ToInt32(linha["id_cliente"]);
                venda.IdProduto = Convert.ToInt32(linha["id_produto"]);
                venda.Quantidade = Convert.ToInt32(linha["quantidade"]);
                venda.Total = Convert.ToDecimal(linha["total"]);
                vendas.Add(venda);
            }
            return vendas;
        }

        protected void Alterar(Venda venda)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE venda SET id_cliente = @ID_CLIENTE, id_produto = @ID_PRODUTO, quantidade = @QUANTIDADE, total = @TOTAL WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID_CLIENTE", venda.IdCliente);
            comando.Parameters.AddWithValue("@ID_PRODUTO", venda.IdProduto);
            comando.Parameters.AddWithValue("@QUANTIDADE", venda.Quantidade);
            comando.Parameters.AddWithValue("@TOTAL", venda.Total);
            comando.Parameters.AddWithValue("@ID", venda.Id);
            comando.ExecuteNonQuery();
        }

        protected void Apagar(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "DELETE FROM venda WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
        }
    }

}
