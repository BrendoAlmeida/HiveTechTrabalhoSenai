using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    public class ClienteDAO
    {
        public MySqlConnection conexao { get; set; }

        public ClienteDAO()
        {
            conexao = new MySqlConnection("Server=localhost;Database=hivetechdb;Uid=root;Pwd=;");
            conexao.Open();
        }

        internal void Inserir(Cliente cliente)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO cliente (nome, email, senha, cpf, data_de_nascimento) VALUES (@nome, @email,sha2( @senha, 256), @cpf, @data_de_nascimento)";
            comando.Parameters.AddWithValue("@nome", cliente.Nome);
            comando.Parameters.AddWithValue("@email", cliente.Email);
            comando.Parameters.AddWithValue("@senha", cliente.Senha);
            comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
            comando.Parameters.AddWithValue("@data_de_nascimento", DateTime.Parse(cliente.Data_Nascimento).ToString("yyyy-MM-dd"));
            comando.ExecuteNonQuery();
        }

        internal List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM cliente WHERE id NOT IN(SELECT id FROM administrador);";

            MySqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                Cliente cliente = new Cliente (reader["nome"].ToString(), reader["email"].ToString(), reader["senha"].ToString() , reader["cpf"].ToString(), reader["data_de_nascimento"].ToString(), int.Parse(reader["id"].ToString()));
                clientes.Add(cliente);

            }
            reader.Close();
            return clientes;
        }

        internal void Alterar(Cliente cliente)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE cliente SET nome = @Nome, email = @Email, senha = @Senha, cpf = @Cpf, data_de_nascimento = @Data_de_nascimento WHERE id = @ID";
            comando.Parameters.AddWithValue("@Nome", cliente.Nome);
            comando.Parameters.AddWithValue("@Email", cliente.Email);
            comando.Parameters.AddWithValue("@Senha", cliente.Senha);
            comando.Parameters.AddWithValue("@Cpf", cliente.Cpf);
            comando.Parameters.AddWithValue("@Data_de_nascimento", cliente.Data_Nascimento);
            comando.ExecuteNonQuery();
        }

        internal void Apagar(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM cliente WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();

        }

        internal void TornarAdministrador(int id, string Chave)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO administrador (id_cliente, chaveDeAcesso) VALUES (@id, SHA2(@chaveDeAcesso, 256))";
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@chaveDeAcesso", Chave);
            comando.ExecuteNonQuery();
        }
    }

}
