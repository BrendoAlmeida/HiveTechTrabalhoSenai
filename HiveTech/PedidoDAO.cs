using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveTech
{
    internal class PedidoDAO
    {
        public MySqlConnection conexao { get; set; }

        public PedidoDAO()
        {
            conexao = new MySqlConnection("Server=localhost;Database=HiveTechDB;Uid=root;Pwd=;");
            conexao.Open();
        }

        public List<ItensCarrinho> ListarPedidos(int IdCliente)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"select * from pedidos as p inner join itenspedidos as i inner join produto as pr where i.id_pedido = p.id_pedido and i.id_produto = pr.id and id_cliente = @IdCliente";
            comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            MySqlDataReader reader = comando.ExecuteReader();
            List<ItensCarrinho> pedidos = new List<ItensCarrinho>();
            while (reader.Read())
            {
                ItensCarrinho pedido = new ItensCarrinho(reader.GetInt32("id_pedido"), reader.GetString("produto"), reader.GetDecimal("Preco"), reader.GetString("Imagem"), reader.GetInt32("Quantidade"), reader.GetDecimal("sub_total"));
                pedidos.Add(pedido);
            }
            conexao.Close();
            return pedidos;
        }
    }
}
